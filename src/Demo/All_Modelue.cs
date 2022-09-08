using Autofac;
using Demo.Models;
using Demo.Models.Teacher;

namespace Demo
{
    public class All_Modelue:Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TeacherReposity>().As<ITeacher>();
            builder.RegisterType<MokEmpolye>().As<IEmploye>();
            base.Load(builder);
        }
    }
}
