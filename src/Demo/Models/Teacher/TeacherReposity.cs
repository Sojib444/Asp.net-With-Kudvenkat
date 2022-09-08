namespace Demo.Models.Teacher
{
    public class TeacherReposity : ITeacher
    {
        List<Teacher> teachers = new List<Teacher>()
        {
            new Teacher() { Id = 1, Name = "Rabi", Address = "Khulna" },
            new Teacher() { Id=2,Name="Khirul",Address="Kushtia"},
            new Teacher() { Id=3,Name="Saddam",Address="Lalmatia"},
            new Teacher() { Id=4,Name="Saddam",Address="Lalmatia"}

        };

        public Teacher specificTeacher(int id)
        {
            return teachers.Where(e => e.Id ==id).FirstOrDefault();
            
        }

        public List<Teacher> getTeacher()
        {
            return teachers;

        }
    }
}
