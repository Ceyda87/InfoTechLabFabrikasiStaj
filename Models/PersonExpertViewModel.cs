using System.Drawing;

namespace InfoTechLabProjeFabrikasi.Models
{
    public class PersonExpertViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string EMail { get; set; }
    }
    public class PersonCustomerViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string? EMail { get; set; }
    }
}
