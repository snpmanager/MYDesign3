using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MYDesign3.Models
{
    public class CreateQuotation
    {
        #region 用户ID
        [Key]
        public Guid UserInfoID { get; set; }
        #endregion 服务代码
        [Required, StringLength(15)]
        [Display(Name = "订单服务代码")]
        public string ServiceCode { get; set; }
        # region 燃油类型
        [Required] 
        [Display(Name = "燃油类型")]
        public VSO_LIBS.DatasModels.ModelType.EFuelType FuelType { get; set; }
        #endregion
        #region 调和油比重
        [Display(Name = "调和油比重")]
        public decimal BlendedFuelScale { get; set; }
        #endregion
        #region 预计加油日期
        [Display(Name = "预计服务日期")]
        public DateTime InquiryServiceDate { get; set; }
        #endregion 调整加油日期
        [Display(Name = "调整服务日期")]
        public DateTime AdjustServiceDate { get; set; }
        #region
        #endregion
        #region 预计加油地点
        [Display(Name = "询价纬度")]
        public double Inquiry_B { get; set; }
        [Display(Name = "询价纬度")]
        public double Inquiry_L { get; set; }
        #endregion
        #region 调整加油地点
        [Display(Name = "调整纬度")]
        public double Adjust_B { get; set; }
        [Display(Name = "调整纬度")]
        public double Adjust_L { get; set; }
        #endregion
        #region
        [Display(Name = "所在渔场")]
        public VSO_LIBS.DatasModels.ModelType.EFishingGroudType LocateFishingGround { get; set; }
        #endregion
        #region 报价接收截止时间
        [Display(Name = "报价单截止时间")]
        public string OpenTime { get; set; }
        #endregion
        #region 报价有效期限
        [Display(Name = "报价有效期限")]
        public string ValidTime { get; set; }
        #endregion
        #region 报价
        [Display(Name = "报价")]
        [Required(ErrorMessage = "请填入您的报价"), Range(0, 5000)]
        public decimal Quoatation { get; set; }
        #endregion
        #region
        #endregion
        #region
        #endregion
        #region
        #endregion
    }
}