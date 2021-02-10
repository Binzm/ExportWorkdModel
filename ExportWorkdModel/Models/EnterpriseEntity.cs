using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ExportWorkdModel.Models
{
   
    public class EnterpriseEntity
    {
         #region 实体成员
        /// <summary>
        /// id
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 团队名
        /// </summary>
        [Description("企业名称")]
        public string v1 { get; set; }
        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [Description("统一社会信用代码")]
        public string v3 { get; set; }
        /// <summary>
        /// 成立日期
        /// </summary>
        [Description("成立日期")]
        public string v4 { get; set; }

        /// <summary>
        /// 参赛行业领域
        /// </summary>
        [Description("参赛行业领域")]
        public string v5 { get; set; }
        /// <summary>
        /// 行政区域
        /// </summary>
        [Description("行政区域")]
        public string v6 { get; set; }
        /// <summary>
        /// 是否属于国家高新区内的企业
        /// </summary>
        [Description("属于国家高新区内的企业")]
        public string v7 { get; set; }
        /// <summary>
        /// 是否属于国家级经济开发区内的企业
        /// </summary>
        [Description("属于国家级经济开发区内的企业")]
        public string v9 { get; set; }
        /// <summary>
        /// 是否属于国家级科技企业孵化器内的企业
        /// </summary>
        [Description("属于国家级科技企业孵化器内的企业")]
        public string v11 { get; set; }
        /// <summary>
        /// 是否属于国家大学科技园内的企业
        /// </summary>
        [Description("属于国家大学")]
        public string v13 { get; set; }
        /// <summary>
        /// 是否国家备案的众创空间内的企业
        /// </summary>
        [Description("国家备案的众创空间内的企业")]
        public string v20 { get; set; }
        /// <summary>
        /// 企业注册类型
        /// </summary>
        [Description("企业注册类型")]
        public string v22 { get; set; }
        /// <summary>
        /// 注册资本
        /// </summary>
        [Description("注册资本")]
        public string v24 { get; set; }
        /// <summary>
        /// 实收资本(万元人民币)
        /// </summary>
        [Description("实收资本")]
        public string v25 { get; set; }
        /// <summary>
        /// 企业注册地址
        /// </summary>
         [Description("企业注册地址")]
        public string v26 { get; set; }
        /// <summary>
        /// 邮政编码
        /// </summary>
        [Description("注册地邮政编码")]
        public string v27 { get; set; }
        /// <summary>
        /// 通信地址
        /// </summary>
          [Description("通信地址")]
        public string v28 { get; set; }
        /// <summary>
        /// 邮政编码
        /// </summary>
         [Description("通讯地邮政编码")]
        public string v29 { get; set; }
        /// <summary>
        /// 企业网址
        /// </summary>
        [Description("企业网址")]
        public string v30 { get; set; }
        /// <summary>
        /// 企业官方微信
        /// </summary>
        [Description("企业官方微信")]
        public string v31 { get; set; }
        /// <summary>
        /// 职工总数
        /// </summary>
         [Description("职工总数")]
        public string v32 { get; set; }
        /// <summary>
        /// 博   士人数
        /// </summary>
        [Description("博   士")]
        public string v33 { get; set; }
        /// <summary>
        /// 硕   士人数
        /// </summary>
        [Description("硕   士")]
        public string v34 { get; set; }
        /// <summary>
        /// 本   科人数
        /// </summary>
        [Description("本   科")]
        public string v35 { get; set; }
        /// <summary>
        /// 大专及以下人数
        /// </summary>
        [Description("大专及以下")]
        public string v36 { get; set; }
        /// <summary>
        /// 高级职称人数
        /// </summary>
        [Description("高级职称")]
        public string v37 { get; set; }
        /// <summary>
        /// 中级职称人数
        /// </summary>
        [Description("中级职称")]
        public string v38 { get; set; }
        /// <summary>
        /// 初级职称人数
        /// </summary>
        [Description("初级职称")]
        public string v39 { get; set; }
        /// <summary>
        /// 高级技工人数
        /// </summary>
        [Description("高级技工")]
        public string v40 { get; set; }
        /// <summary>
        /// 上市公司控股企业是否
        /// </summary>
        [Description("上市公司控股企业")]
        public string v41 { get; set; }
        /// <summary>
        /// 新三板企业是否
        /// </summary>
        [Description("新三板企业")]
        public string v42 { get; set; }
        /// <summary>
        /// 高新技术企业是否
        /// </summary>
        [Description("高新技术企业")]
        public string v43 { get; set; }
        /// <summary>
        /// 获得时间
        /// </summary>
        [Description("获得时间")]
        public string v44 { get; set; }
        /// <summary>
        /// 登记入库的科技型中小企业是否
        /// </summary>
        [Description("登记入库的科技型中小企业")]
        public string v45 { get; set; }
        /// <summary>
        /// 企业概要（不超1000字）
        /// </summary>
        [Description("企业概要")]
        public string v46 { get; set; }
        /// <summary>
        /// 关 键 词
        /// </summary>
        [Description("关 键 词")]
        public string v47 { get; set; }
        /// <summary>
        /// 现融资阶段
        /// </summary>
        [Description("现融资阶段")]
        public string v48 { get; set; }
        /// <summary>
        /// 参赛项目产品图片
        /// </summary>
        public string v49 { get; set; }
        /// <summary>
        /// 参赛项目收入占去年企业营业收入比例
        /// </summary>
        [Description("参赛项目收入占去年企业营业收入比例")]
        public string v50 { get; set; }
        /// <summary>
        /// 参赛项目介绍（1000字以内）
        /// </summary>
        [Description("参赛项目介绍（1000字以内）")]
        public string v51 { get; set; }
        /// <summary>
        /// 当前五大客户
        /// </summary>
        [Description("当前五大客户")]
        public string v52 { get; set; }
        /// <summary>
        /// 当前五大供应商
        /// </summary>
        [Description("当前五大供应商")]
        public string v53 { get; set; }
        /// <summary>
        /// 国内市场地位排名
        /// </summary>
        [Description("国内市场地位排名")]
        public string v54 { get; set; }
        /// <summary>
        /// 商业模式及业务拓展计划
        /// </summary>
        [Description("商业模式及业务拓展计划")]
        public string v56 { get; set; }
        /// <summary>
        /// 经营风险与对策
        /// </summary>
        [Description("经营风险与对策")]
        public string v57 { get; set; }
        /// <summary>
        /// 企业管理模式
        /// </summary>
        [Description("企业管理模式")]
        public string v58 { get; set; }
        /// <summary>
        /// 公司对管理层及关键人员是否已采取激励措施是否
        /// </summary>
        [Description("公司对管理层及关键人员是否已采取激励措施")]
        public string v59 { get; set; }
        /// <summary>
        /// 公司是否考虑员工持股问题？是否
        /// </summary>
        [Description("公司是否考虑员工持股问题")]
        public string v60 { get; set; }
        /// <summary>
        /// 企业其他技术、产品及服务（1000字以内）
        /// </summary>
        [Description("企业其他技术、产品及服务（1000字以内）")]
        public string v61 { get; set; }
        /// <summary>
        /// 参赛目的
        /// </summary>
        [Description("参赛目的")]
        public string v62 { get; set; }
        /// <summary>
        /// 并购需求
        /// </summary>
        [Description("并购需求")]
        public string v63 { get; set; }
        /// <summary>
        /// 申请大赛组织的大企业对接活动是否
        /// </summary>
        [Description("申请大赛组织的大企业对接活动")]
        public string v64 { get; set; }
        /// <summary>
        /// 资金使用计划
        /// </summary>
        [Description("债权融资资金使用计划")]
        public string v65 { get; set; }
        /// <summary>
        /// 股权融资需求是否  
        /// </summary>
        [Description("直接从事研发科技人员数")]
        public string v66 { get; set; }
        /// <summary>
        /// 融资金额（万元￥）
        /// </summary>
        [Description("上年度吸纳高校应届毕业生人数")]
        public string v67 { get; set; }
        /// <summary>
        /// 拟出让股权比例
        /// </summary>
        [Description("参赛项目名称")]
        public string v68 { get; set; }
        /// <summary>
        /// 融资时间
        /// </summary>
        [Description("产品市场分析及竞争优势")]
        public string v69 { get; set; }
        /// <summary>
        /// 资金使用计划
        /// </summary>
        [Description("股权融资资金使用计划")]
        public string v70 { get; set; }
        /// <summary>
        /// 申请大赛推荐投资机构是否  (修改 申请大赛推荐信贷机构)
        /// </summary>
        [Description("申请大赛推荐信贷机构")]
        public string v71 { get; set; }
        /// <summary>
        /// 申请大赛组织的融资路演是否 （修改 申请大赛推荐投资机构）
        /// </summary>
        [Description("申请大赛推荐投资机构")]
        public string v72 { get; set; }
        /// <summary>
        /// 申请国家科技成果转化引导基金设立的子基金推荐 (修改 申请大赛组织的融资路演)
        /// </summary>
        [Description("申请大赛组织的融资路演")]
        public string v73 { get; set; }
        #endregion

        public List<string> GetThisDescriptionName()
        {
            var result = new List<string>();
            GetType().GetProperties().ToList().ForEach(f =>
           {
               var descriptionObj = (DescriptionAttribute[])f.GetCustomAttributes(typeof(DescriptionAttribute), false);
               if (descriptionObj.Length > 0 && !string.IsNullOrWhiteSpace(descriptionObj[0].Description))
               {
                   result.Add(descriptionObj[0].Description);
               }
           });
            return result;
        }
    }

}