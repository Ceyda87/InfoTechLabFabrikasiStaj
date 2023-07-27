using System.ComponentModel.DataAnnotations;

namespace InfoTechLabProjeFabrikasi.Models
{
    public class ExpertViewModel
    {
        public int Id { get; set; }
        [Display(Name ="Adı-Soyadı")]
        public string FullName { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
        public string ServiceArea { get; set; }
    }
}
