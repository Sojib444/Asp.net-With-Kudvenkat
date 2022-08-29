using Autofac;
using Demo.Models;

namespace Demo
{
    public class EmpolyeModule:Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MokEmpolye>().As<IEmploye>();
            base.Load(builder);
        }
    }
}
