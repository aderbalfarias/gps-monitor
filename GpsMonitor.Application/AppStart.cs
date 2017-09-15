using GpsMonitor.Application.App;
using GpsMonitor.Application.Interfaces;
using GpsMonitor.Data.Repositories;
using GpsMonitor.Domain.Interfaces.Repositories;
using GpsMonitor.Domain.Interfaces.Services;
using GpsMonitor.Domain.Services;
using Ninject;

namespace GpsMonitor.Application
{
    public static class AppStart
    {
        public static void NinjectContainer(IKernel kernel)
        {
            kernel.Bind(typeof(IAppBase<>)).To(typeof(AppBase<>));
            kernel.Bind<IUsuarioApp>().To<UsuarioApp>();
            kernel.Bind<IPerfilApp>().To<PerfilApp>();
            kernel.Bind<IEmailApp>().To<EmailApp>();
            kernel.Bind<ILocalizacaoApp>().To<LocalizacaoApp>();

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<IUsuarioService>().To<UsuarioService>();
            kernel.Bind<IPerfilService>().To<PerfilService>();
            kernel.Bind<IEmailService>().To<EmailService>();
            kernel.Bind<ILocalizacaoService>().To<LocalizacaoService>();

            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<IUsuarioRepository>().To<UsuarioRepository>();
            kernel.Bind<IPerfilRepository>().To<PerfilRepository>();
            kernel.Bind<ILocalizacaoRepository>().To<LocalizacaoRepository>();
        }
    }
}
