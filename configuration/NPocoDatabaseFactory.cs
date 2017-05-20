using NPoco;
using NPoco.FluentMappings;

namespace GFramework.data.npoco.configuration
{
    public static class NPocoDatabaseFactory
    {

        public static DatabaseFactory DbFactory { get; set; }

       
        public static void Setup(Mappings MappingClass)
        {
            var fluentConfig = FluentMappingConfiguration.Configure(MappingClass);

            DbFactory = DatabaseFactory.Config(x =>
            {
                x.UsingDatabase(() => new Database("CommandsDb"));
                x.WithFluentConfig(fluentConfig);
                //x.WithMapper(new Mapper());
            });
        }


    }
}
