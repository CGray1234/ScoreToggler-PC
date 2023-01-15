using ScoreToggler.Configuration;
using ScoreToggler.Managers;
using ScoreToggler.UI.FlowCoordinator;
using ScoreToggler.UI.ViewController;
using Zenject;
using BeatSaberMarkupLanguage.MenuButtons;

namespace ScoreToggler.Installers
{
    internal class STMenuInstaller : Installer
    {
        private readonly STConfig _config;

        public STMenuInstaller(STConfig config)
        {
            _config = config;
        }

        public override void InstallBindings()
        {
            Container.BindInstance(_config);
            Container.BindInterfacesTo<STMenuButtonManager>().AsSingle();
            Container.Bind<STFlowCoordinator>().FromNewComponentOnNewGameObject().AsSingle();
            Container.Bind<STViewController>().FromNewComponentAsViewController().AsSingle();
        }
    }
}