using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adk.GoogleApis;
using AutoMapper;
using Castle.Facilities.Logging;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Services.Logging.Log4netIntegration;
using Castle.Windsor;
using Tasker.Service.Providers;

namespace Tasker.Service.Infrastructure
{
    public class Installer : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.AddFacility<LoggingFacility>(f => f.LogUsing<Log4netFactory>());
            //  container.AddFacility<PersistenceFacility>();

            container.Register(

                Component
                    .For<MyService>()
                    .LifeStyle.Transient,

                  Component
                    .For<ApisManager>()
                    .LifeStyle.Transient,


                  Component
                    .For<Tasker.BL.Pub.Providers.IConfigurationProvider>()
                    .ImplementedBy<ConfigurationProvider>()
                    .UsingFactoryMethod(_ =>
                    {
                        var location = System.Reflection.Assembly.GetEntryAssembly().Location;

                        var dirName = Path.GetDirectoryName(location);

                        var path = Path.Combine(dirName, "credentials.json");

                        var config = new ConfigurationProvider
                        {
                            JsonCredentialPath = path,
                            SpreedsheetId = "1E8mIiUaQFwrucOF36zIx2PDq4xKVuWGH4did8ltx_Dw",
                        };

                        return config;
                    })
                    .LifeStyle.Singleton

            //Component
            //.For<IMapper>()
            //.UsingFactoryMethod(_ => 
            //{
            //    var mapper = new MapperConfiguration(x => x.AddProfiles("", ""));

            //    return mapper.CreateMapper();                    

            //}).LifeStyle.Singleton

            );
        }
    }
}
