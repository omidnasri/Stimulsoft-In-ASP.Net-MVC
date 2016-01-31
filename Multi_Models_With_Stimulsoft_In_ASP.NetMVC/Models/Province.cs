using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Multi_Models_With_Stimulsoft_In_ASP.NetMVC.Models
{
    [Table("Province")]
    public class Province
    {
        #region Properties
        /// <summary>
        /// کلید جدول
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// نام استان
        /// </summary>
        public string Name { get; set; }
        #endregion

        #region Key
        /// <summary>
        /// ایجاد رابطه یک به چند به جدول شهرستان‌ها
        /// </summary>
        public virtual IList<City> Citys { get; set; }
        #endregion
    }
}