using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MYDesign3.Models
{
    public enum InquiryValidation
    {
        [Display(Name = "2小时")]
        hours2,
        [Display(Name = "4小时")]
        hours4,
        [Display(Name = "12小时")]
        hours12,
        [Display(Name = "24小时")]
        hours24,
        [Display(Name = "48小时")]
        hours48

    }
    public enum PayCurrency
    {
        美元,
        人民币,
    }
    public class CreateInquiry
    {
        #region 用户ID
        [Key]
        public Guid UserInfoID { get; set; }
        #endregion
        #region 服务代码
        [Required, StringLength(15)]
        [Display(Name = "订单服务代码")]
        public string ServiceCode { get; set; }
        #endregion
        #region 选择要加油的船只
        [Required(ErrorMessage = "请从您的船队中至少选择一条需要加油的船只")]
        [Display(Name = "我的船队")]
        public ICollection<FishVessel> VesselNeedBunker { get; set; }
        #endregion
        #region
        [Required(ErrorMessage = "请选择您要加油的型号")]
        [Display(Name = "选择燃油型号")]
        public VSO_LIBS.DatasModels.ModelType.EFuelType FuelType { get; set; }
        #endregion
        #region 调和油比重
        [Display(Name = "调和油比重")]
        public decimal BlendedFuelScale { get; set; }
        #endregion
        #region 询价单有效期
        [Required]
        [Display(Name = "请选择询价单有效期")]
        public InquiryValidation IV { get; set; }
        #endregion
        #region 询价单过期日期
        [Required, ScaffoldColumn(false)]
        [Display(Name = "询价单过期日期")]
        public DateTime InquiryExpiryDate { get; set; }
        #endregion
        #region 询价经纬度
        [Required, Range(-90, 90)]
        [Display(Name = "询价纬度")]
        public double Inquiry_B { get; set; }
        [Required, Range(-180, 180)]
        [Display(Name = "询价纬度")]
        public double Inquiry_L { get; set; }
        #endregion
        #region 所在渔场
        [Required]
        [Display(Name = "所在渔场")]
        public VSO_LIBS.DatasModels.ModelType.EFishingGroudType LocateFishingGround { get; set; }
        #endregion
        #region 预计服务日期
        [Required]
        [Display(Name = "预计服务日期")]
        public DateTime InquiryServiceDate { get; set; }
        #endregion
        #region 是否允许变更
        [Required]
        [Display(Name = "是否允许变更地点")]
        public bool IsRelocatable { get; set; }
        [Required]
        [Display(Name = "是否允许变更日期")]
        public bool IsRedate { get; set; }
        #endregion
        #region 支付货币
        [Display(Name = "选择您希望支付货币")]
        public PayCurrency PayCurrency { get; set; }
        #endregion
        #region 创建及更新时间
        [Required, ScaffoldColumn(false)]
        [Display(Name = "创建时间")]
        public DateTime CreateTime { get; set; }
        #endregion

    }
    public class CreateInquiryDbContext : DbContext {
        public CreateInquiryDbContext()
        {
        }
        public DbSet<CreateInquiry> CreateInquiries { get; set; }
    }
}