﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExportWorkdModel.Models;
using Newtonsoft.Json;

namespace ExportWorkdModel.Controllers
{
    public class HomeController : Controller
    {
        private static string _enterpriseStr = "{\"id\":\"08c69df1-9f30-4e7f-9ebd-7b14cf2747d7\",\"company_id\":\"7daed023-5d41-47ac-bed5-3c8b568130d8\",\"state\":1,\"v1\":\"内蒙古农科技责公司\",\"v2\":null,\"v3\":\"9111232325MA0444W401\",\"v4\":\"2015-11-25\",\"v5\":\"6\",\"v6\":\"0\",\"v7\":\"2\",\"v8\":\"\",\"v9\":\"2\",\"v10\":\"\",\"v11\":\"1\",\"v12\":\"0\",\"v13\":\"2\",\"v14\":\"\",\"v20\":\"2\",\"v21\":\"\",\"v22\":\"youxianzerengongsi\",\"v23\":null,\"v24\":\"500\",\"v25\":\"500\",\"v26\":\"内蒙古自治区呼和浩特市绿地大厦\",\"v27\":\"017000\",\"v28\":\"内蒙古自治区呼和浩特市绿地大厦\",\"v29\":\"017000\",\"v30\":\"无\",\"v31\":\"nmmj588\",\"v32\":\"14\",\"v33\":\"0\",\"v34\":\"1\",\"v35\":\"5\",\"v36\":\"8\",\"v37\":\"0\",\"v38\":\"0\",\"v39\":\"5\",\"v40\":\"1\",\"v41\":\"2\",\"v42\":\"2\",\"v43\":\"1\",\"v44\":\"2019-12-04\",\"v45\":\"2\",\"v46\":\"一、企业概况一、企业概况一、企业概况一、企业概况一、企业概况一、企业概况一、企业概况一、企业概况一、企业概况一、企业概况一、企业概况一、企业概况一、企业概况一、企业概况一、企业概况一、企业概况\",\"v47\":\"生态配方花费\",\"v48\":\"0\",\"v49\":\"6c924c29-d9b1-4f84-dac8-750867c54f9b\",\"v50\":\"0\",\"v51\":\"全周期为土地和农民提供优质服务。全周期为土地和农民提供优质服务。全周期为土地和农民提供优质服务。全周期为土地和农民提供优质服务。全周期为土地和农民提供优质服务。全周期为土地和农民提供优质服务。全周期为土地和农民提供优质服务。全周期为土地和农民提供优质服务。全周期为土地和农民提供优质服务。全周期为土地和农民提供优质服务。全周期为土地和农民提供优质服务。\",\"v52\":\"康巴什酒业、百家旺合作社、庆隆合作社、兆丰粮油有限公司、秦盟农业\",\"v53\":\"中农集团、西北农林科技大学、润田生物科技有限公司、博秦生物工程有限公司、安丘供销康田农业科技有限公司\",\"v54\":\"0\",\"v55\":\"0\",\"v56\":\"对配方的使用用推广具有极大的促进作用。\",\"v57\":\"经营风险：没有。其次是小企业，周转自己紧张。\",\"v58\":\"企业管理模式：企业属于创业初期已初具模板，正在逐步完善。\",\"v59\":\"2\",\"v60\":\"2\",\"v61\":\"配备物流配送车辆等。配备物流配送车辆等。配备物流配送车辆等。配备物流配送车辆等。配备物流配送车辆等。\",\"v62\":\"0\",\"v63\":\"2\",\"v64\":\"1\",\"v65\":\"\",\"v66\":\"0\",\"v67\":\"0\",\"v68\":\"产品的研究与试验\",\"v69\":\"微生菌：这个在农业上的意义就非常重大了。微生菌：这个在农业上的意义就非常重大了。微生菌：这个在农业上的意义就非常重大了。微生菌：这个在农业上的意义就非常重大了。微生菌：这个在农业上的意义就非常重大了。微生菌：这个在农业上的意义就非常重大了。微生菌：这个在农业上的意义就非常重大了。微生菌：这个在农业上的意义就非常重大了。微生菌：这个在农业上的意义就非常重大了。\",\"v70\":\"\",\"v71\":\"2\",\"v72\":\"2\",\"v73\":\"2\",\"v74\":\"\",\"v75\":\"\",\"v76\":\"\",\"v77\":\"1\",\"v79\":\"\",\"v80\":\"\",\"v81\":\"\",\"v82\":\"\",\"v83\":\"\",\"v84\":\"\",\"type\":\"chengzhangzu\",\"v85\":\"\",\"v86\":null,\"contactPersonName\":null,\"contactPersionTel\":null}";
      
        public ActionResult GetExport()
        {
            string title = "测试导出Word文件";
            var doc = ExportFileOperator.CreateBuilder("GroupForm.doc");
            ExportFileOperator.InsertTitle(ref doc.Item2, title);//插入标题
            EnterpriseEntity enterprise = JsonConvert.DeserializeObject<EnterpriseEntity>(_enterpriseStr);
            ExportFileOperator.InsertFormData(enterprise, ref doc.Item1);//实体数据插入
            return new ExportFileOperator().FileResult(title, doc.Item1);
        }

          public ActionResult Index()
        {
            return View();
        }

    }
}