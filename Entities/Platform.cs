using System.ComponentModel.DataAnnotations;

namespace InfoTechLabProjeFabrikasi.Data
{
    public class Platform:EntityBase
    {
        public string Name { get; set; } = "";

        [Display(Name= "Kategori")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        [Display(Name= "Usta")]
        public int ExpertId { get; set; }
        public virtual Expert Expert { get; set; }

        [Display(Name="Müşteri")]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
