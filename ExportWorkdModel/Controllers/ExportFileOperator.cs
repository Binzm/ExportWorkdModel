using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Aspose.Words;
using Aspose.Words.Drawing;
using Aspose.Words.Tables;

namespace ExportWorkdModel.Controllers
{
    public class ExportFileOperator:Controller
    {
        private static string _tempPath = AppDomain.CurrentDomain.BaseDirectory;

        public static (Document doc, DocumentBuilder builder) CreateBuilder(string tempFileName)
        {
            string tempPath = $"{_tempPath}{tempFileName}";
            Document doc = new Document(tempPath);
            return (doc, new DocumentBuilder(doc));
        }
        public FileResult FileResult(string fileName, Document doc)
        {
            var filePathName = $"{fileName}.doc";
            doc.Save(Path.Combine(_tempPath, "temp", filePathName), SaveFormat.Doc); //保存word
            filePathName = Path.Combine(_tempPath, "temp", filePathName);
            return File(filePathName, "application/doc", $"{fileName}.Doc");
        }
        public static void InsertTitle(ref DocumentBuilder builder, string fileName, string tempBookMarkName = "title")
        {
            builder.MoveToBookmark(tempBookMarkName);
            builder.Write(fileName);
        }

      

        public static void MoveToBookmark(string tempBookMarkName, ref DocumentBuilder builder)
        {
            builder.MoveToBookmark(tempBookMarkName);
        }

        public static void InsertPic(IEnumerable<string> data, string tempBookMarkName, ref DocumentBuilder builder)
        {
            if (data.Count() <= 0)
            {
                return;
            }
            MoveToBookmark(tempBookMarkName, ref builder);
            List<string> picPathList = new List<string>();
            foreach (var x1 in data)
            {
                builder.InsertImage(x1, RelativeHorizontalPosition.Page, 10, RelativeVerticalPosition.Page, 10, 100, 125, WrapType.Inline);
            }
        }

        public static void InsertFormData<T>(T objFormData, ref Document document)
        {
            NodeCollection allTables = document.GetChildNodes(NodeType.Table, true);
            List<string> headDescribeNameList = GetObjectHeadDescription<T>();//获取实体中每个Description中的值
            foreach (Table tableFirst in allTables)
            {
                for (int headIndex = 0; headIndex < headDescribeNameList.Count; headIndex++)//循环实体中的每个DescribeName
                {
                    for (int rowIndex = 0; rowIndex < tableFirst.Rows.Count; rowIndex++)//遍历word模板中所有的table
                    {
                        for (int cellIndex = 0; cellIndex < tableFirst.Rows[rowIndex].Cells.Count; cellIndex++)//遍历模板中所有的table每行的列数
                        {
                            if (tableFirst.Rows[rowIndex].Cells[cellIndex].GetText() != null && tableFirst.Rows[rowIndex].Cells[cellIndex].GetText().Contains(headDescribeNameList[headIndex]) &&
                                  ((tableFirst.Rows[rowIndex].Cells.Count > cellIndex && tableFirst.Rows[rowIndex].Cells[cellIndex + 1] != null && tableFirst.Rows[rowIndex].Cells[cellIndex + 1].GetText().Equals("\a")) || (tableFirst.Rows.Count > rowIndex && tableFirst.Rows[rowIndex + 1] != null && tableFirst.Rows[rowIndex + 1].Cells[cellIndex] != null && tableFirst.Rows[rowIndex + 1].Cells[cellIndex].GetText().Equals("\a"))))//如果遍历的cell不为空、其中的值能和DescribeName匹配上，并且这个单元的右边的cell或者下边cell有占位，而且是空，就在此处插入值
                            {
                                var objValue = GetObjectValueByPropName(objFormData, headDescribeNameList[headIndex]);//根据DescribeName获取对应的值
                                if (tableFirst.Rows[rowIndex].Cells.Count > cellIndex && tableFirst.Rows[rowIndex].Cells[cellIndex + 1] != null && tableFirst.Rows[rowIndex].Cells[cellIndex + 1].GetText().Equals("\a"))
                                {
                                    InsertCell(objValue, document, tableFirst.Rows[rowIndex].Cells[cellIndex + 1]);//优先在右变空位插入值
                                    break;
                                }
                                InsertCell(objValue, document, tableFirst.Rows[rowIndex + 1].Cells[cellIndex]);//右侧如果没有就在下边空位插入值
                                break;
                            }
                        }
                    }
                }
            }
        }

        public static List<string> GetObjectHeadDescription<T>()
        {
            var obj = Activator.CreateInstance<T>();
            MethodInfo method = obj.GetType().GetMethod("GetThisDescriptionName", new Type[] { });//每个实体需要有GetThisDescriptionName这个方法
            return (List<string>)(method?.Invoke(obj, null));
        }
        private static string GetObjectValueByPropName<T>(T objFormData, string descriptionName)
        {
            try
            {
                var properties = objFormData.GetType().GetProperties();
                foreach (var propertyInfo in properties)
                {
                    var descriptionAttributes = (DescriptionAttribute[])propertyInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
                    if (descriptionAttributes.Length > 0 && !string.IsNullOrWhiteSpace(descriptionAttributes[0].Description) && descriptionAttributes[0].Description.Equals(descriptionName))
                    {
                        return propertyInfo.GetValue(objFormData) == null ? "无" : propertyInfo.GetValue(objFormData).ToString();
                    }
                }
                return "无";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private static void InsertCell(string value, Document doc, Cell cell)
        {
            Cell insertCell = cell;
            insertCell.FirstParagraph.Remove();
            Paragraph p = new Paragraph(doc);
            p.AppendChild(new Run(doc, (value == null ? "" : value)));
            p.ParagraphFormat.Alignment = ParagraphAlignment.Center;
            insertCell.CellFormat.VerticalAlignment = CellVerticalAlignment.Center;
            insertCell.AppendChild(p);
        }
    }
}