using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Dyan.OceanAngular.Localization
{
    public static class OceanAngularLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(OceanAngularConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(OceanAngularLocalizationConfigurer).GetAssembly(),
                        "Dyan.OceanAngular.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
