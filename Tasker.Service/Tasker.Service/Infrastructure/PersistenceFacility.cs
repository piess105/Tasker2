using Castle.MicroKernel.Facilities;
using Castle.MicroKernel.Registration;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace Tasker.Service.Infrastructure
{
    public class PersistenceFacility : AbstractFacility
    {
        protected override void Init()
        {
            var config = BuildDatabaseConfiguration();

            Kernel.Register(
                Component.For<ISessionFactory>()
                    .UsingFactoryMethod(_ => config.BuildSessionFactory())
                    .LifeStyle.Singleton,
                Component.For<ISession>()
                    .UsingFactoryMethod(k => k.Resolve<ISessionFactory>().OpenSession())
                    .LifeStyle.Transient
                );
        }

        protected virtual IPersistenceConfigurer SetupDatabase()
        {
            return MySQLConfiguration.Standard.ShowSql().ConnectionString(x => x.FromConnectionStringWithKey("DBConnection"));
        }

        protected virtual void ConfigurePersistence(Configuration config)
        {
            SchemaMetadataUpdater.QuoteTableAndColumns(config);
        }

        private Configuration BuildDatabaseConfiguration()
        {
            return Fluently.Configure()
                .Database(SetupDatabase())
                //.Mappings(m => m.FluentMappings.Add<FlightInfoDaoMap>())


                .ExposeConfiguration(ConfigurePersistence)
                .BuildConfiguration();
        }
    }
}
