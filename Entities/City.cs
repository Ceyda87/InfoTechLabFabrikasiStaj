using System.ComponentModel.DataAnnotations;

namespace InfoTechLabProjeFabrikasi.Data
{
    public class City: EntityBase
    {
        public int CityCode { get; set; }        
        public string Name { get; set; }       


        public string DisplayName => CityCode + " - " + Name;

        public virtual List<Address> Addresses { get; set; }
    }
}
