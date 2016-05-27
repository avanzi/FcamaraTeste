using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FcamaraTeste.Domain.Entidades
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int ID_Produto { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Nome Produto")]
        public string NM_Produto { get; set; }

        [Required]
        [StringLength(80)]
        [Display(Name = "Descrição")]
        public string DS_Produto { get; set; }

        [Column(TypeName = "numeric")]
        [Display(Name = "Preço Unitário")]
        public decimal VL_Unitario { get; set; }
    }
}
