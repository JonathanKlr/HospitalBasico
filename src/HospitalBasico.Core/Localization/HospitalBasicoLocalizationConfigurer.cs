using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace HospitalBasico.Localization
{
    public static class HospitalBasicoLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(HospitalBasicoConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(HospitalBasicoLocalizationConfigurer).GetAssembly(),
                        "HospitalBasico.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
