namespace InfoTechLabProjeFabrikasi.Data
{
    public class EntityBase
    {
        public int Id { get; set; }
    }
    public class PersonBase : EntityBase
    {
        public string Name { get; set; } = "";
        public string MiddleName { get; set; } = "";
        public string Surname { get; set; } = "";
       

        public string FullName => $"{Name} {MiddleName} {Surname}";
    }
}
