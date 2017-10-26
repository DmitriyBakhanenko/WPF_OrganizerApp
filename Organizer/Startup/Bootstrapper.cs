using Autofac;
using Organizer.Data;
using Organizer.ViewModel;

namespace Organizer.Startup
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<PersonDataService>().As<IPersonDataService>();

            return builder.Build();
        }
    }

}
