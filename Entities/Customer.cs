namespace InfoTechLabProjeFabrikasi.Data
{
    public class Customer: EntityBase
    {
        public string Name { get; set; } = "";
        public int PhoneNumber { get; set; }
        public string EMail { get; set; } = ""; 

        public virtual List<Platform> Platforms { get; set; }
        public virtual List<Address> Addresses { get; set; }


    }
}
