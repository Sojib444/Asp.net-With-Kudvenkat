namespace Demo.Models
{
    public class MokEmpolye : IEmploye
    {

        List<Empoly> list = new List<Empoly>()
        {
            new Empoly(){Id=1,Address="Pabna",Name="Sojib"},
            new Empoly(){Id=2,Address="Kushtia",Name="Siam"},
            new Empoly(){Id=3,Address="Gaibandha",Name="Mijan"},
        };
       
        public Empoly GetId( int id)
        {
            return list.Where(e=>e.Id==id).FirstOrDefault();
        }

        public List<Empoly> EmployeeList()
        {
            return list;
        }
    }
}
