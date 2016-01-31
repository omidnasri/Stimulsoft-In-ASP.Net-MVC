using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Multi_Models_With_Stimulsoft_In_ASP.NetMVC.Models
{
    [Table("City")]
    public class City
    {
        #region Properties
        /// <summary>
        /// کلید جدول
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// نام شهرستان
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// کلید استان انتخابی
        /// </summary>
        public int Province_Id { get; set; }
        #endregion

        #region ForeignKey
        /// <summary>
        /// کلید خارجی به جدول استان‌ها
        /// </summary>
        [ForeignKey("Province_Id")]
        public virtual Province Province { get; set; }
        #endregion
    }
}