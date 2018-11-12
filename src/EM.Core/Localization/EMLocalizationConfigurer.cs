using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace EM.Localization
{
   public static class EMLocalizationConfigurer
   {
      public static void Configure(ILocalizationConfiguration localizationConfiguration)
      {
         localizationConfiguration.Sources.Add(
            new DictionaryBasedLocalizationSource(EMConsts.LocalizationSourceName,
               new XmlEmbeddedFileLocalizationDictionaryProvider(
                  typeof(EMLocalizationConfigurer).GetAssembly(),
                  "EM.Localization.SourceFiles"
               )
            )
         );
      }
   }
}