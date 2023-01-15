using IPA;
using IPA.Config;
using IPA.Config.Stores;
using ScoreToggler.Configuration;
using ScoreToggler.Installers;
using SiraUtil.Zenject;
using IPALogger = IPA.Logging.Logger;

namespace ScoreToggler
{
    [Plugin(RuntimeOptions.DynamicInit)][NoEnableDisable]
    public class Plugin
    {
        [Init]
        public void Init(Config config, IPALogger logger, Zenjector zenjector)
        {
            zenjector.UseSiraSync();
            zenjector.UseLogger(logger);
            zenjector.UseMetadataBinder<Plugin>();

            zenjector.Install<STMenuInstaller>(Location.Menu, config.Generated<STConfig>());
        }
    }
}
