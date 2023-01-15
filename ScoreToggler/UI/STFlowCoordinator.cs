using BeatSaberMarkupLanguage;
using ScoreToggler.UI.ViewController;
using Zenject;

namespace ScoreToggler.UI.FlowCoordinator
{
    internal class STFlowCoordinator : HMUI.FlowCoordinator
    {
        private MainFlowCoordinator _mainFlowCoordinator = null!;
        private STViewController _stViewController = null!;

        [Inject]
        private void Construct(MainFlowCoordinator mainFlowCoordinator, STViewController stViewController)
        {
            _mainFlowCoordinator = mainFlowCoordinator;
            _stViewController = stViewController;
        }

        protected override void DidActivate(bool firstActivation, bool addedToHierarchy, bool screenSystemEnabling)
        {
            SetTitle("Score Toggler");
            showBackButton = true;

            ProvideInitialViewControllers(_stViewController);
        }

        protected override void BackButtonWasPressed(HMUI.ViewController topViewController)
        {
            _mainFlowCoordinator.DismissFlowCoordinator(this);
        }
    }
}