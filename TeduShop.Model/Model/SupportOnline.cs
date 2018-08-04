using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Model
{
    [Table("SupportOnlines")]
    class SupportOnline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        [MaxLength(50)]
        public string Name { set; get; }
        [MaxLength(50)]
        public string Department { set; get; }
        [MaxLength(50)]
        public string Skype { set; get; }
        [MaxLength(50)]
        public string Mobile { set; get; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(50)]
        public string Yahoo { set; get; }
        [MaxLength(50)]
        public string FaceBook { set; get; }
        [MaxLength(50)]
        public string Status { set; get; }
        [MaxLength(50)]
        public int? DisplayOrder { set; get; }

    }
}
