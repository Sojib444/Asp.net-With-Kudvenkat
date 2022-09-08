namespace Demo.Models.Teacher
{
    public interface ITeacher
    {
         List<Teacher> getTeacher();
        Teacher specificTeacher(int id);
        
    }
}
