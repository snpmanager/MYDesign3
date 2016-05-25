using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MYDesign3.Models
{
    public class FishVessel
    {

        #region 船舶ID
        [Key]
        public Guid VesselID { get; set; }
        #endregion
        #region 船舶名称
        [Display(Name = "船舶名称")]
        [Required, StringLength(64, ErrorMessage = "船舶名称不得超过64个字符！")]
        public string VesselName { get; set; }
        #endregion
        #region 船舶类型
        [Display(Name = "船舶类型")]
        [Required]
        public VSO_LIBS.DatasModels.ModelType.EFisherType Type { get; set; }
        #endregion
        #region 呼号
        [Required(ErrorMessage = "请填写呼号"), Display(Name = "呼号"), StringLength(16, ErrorMessage = "呼号不得超过16个字符！")]
        public string CallSign { get; set; }
        #endregion
        #region 卫星电话
        [Required(ErrorMessage = "请填写海事卫星电话号码"), Display(Name = "海事卫星电话号码"), StringLength(16, ErrorMessage = "海事卫星电话号码不得超过16个字符！")]
        public string INMARSAT { get; set; }
        #endregion
        #region 单边带频率
        [Required(ErrorMessage = "请填写单边带"), Display(Name = "单边带"), StringLength(8, ErrorMessage = "单边带不得超过8个字符")]
        public string SSB { get; set; }
        #endregion
        #region 船旗
        [Display(Name = "船旗")]
        [Required]
        public VSO_LIBS.DatasModels.ModelType.EVesselNationalityType Flag { get; set; }
        #endregion
        #region 船籍证书
        [Required(ErrorMessage = "请上传船籍证书"), Display(Name = "船籍证书"), StringLength(128, ErrorMessage = "文件路径过长！")]
        public string VesselNationalityDoc { get; set; }
        #endregion
        #region 鱼货舱容
        [Required(ErrorMessage = "请填写鱼货舱容"), Display(Name = "鱼货舱容（吨）"), Range(0, 9999)]
        public decimal FishCapacity { get; set; }
        #endregion
        #region 燃油仓容
        [Required(ErrorMessage = "请填写燃油舱容"), Display(Name = "燃油舱容（吨）"), Range(0, 5000)]
        public decimal FuelCapacity { get; set; }
        #endregion
    }
    public class FishVesselDbContext : DbContext
    {
        public FishVesselDbContext()
        {
        }
        public DbSet<FishVessel> CreateInquiries { get; set; }
    }
}