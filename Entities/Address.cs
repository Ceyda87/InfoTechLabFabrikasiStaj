using System.ComponentModel.DataAnnotations;

namespace InfoTechLabProjeFabrikasi.Data
{
    public class Address: EntityBase
    {
        [Display(Name="Adres")]
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        [Display(Name = "İlçe")]
        public string Minucipality { get; set; }
        [Display(Name = "Mahalle")]
        public string Districk { get; set; }
        [Display(Name = "Posta Kodu")]
        public int PostCode { get; set; } 

        [Display(Name="Usta")]
        public int ExpertId { get; set; }
        public virtual Expert Expert { get; set; }

        public int CityId { get; set; }
        public virtual City City { get; set; }
    }
}
