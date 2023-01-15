using System;
using BeatSaberMarkupLanguage;
using BeatSaberMarkupLanguage.MenuButtons;
using ScoreToggler.UI.FlowCoordinator;
using Zenject;

namespace ScoreToggler.Managers
{
    internal class STMenuButtonManager : IInitializable, IDisposable
    {
        private readonly MenuButton _menuButton;
        private readonly MainFlowCoordinator _mainFlowCoordinator;
        private readonly STFlowCoordinator _stFlowCoordinator;

        public STMenuButtonManager(MainFlowCoordinator mainFlowCoordinator, STFlowCoordinator stFlowCoordinator)
        {
            _menuButton = new MenuButton("Score Toggler", "Enable/disable score submissions at the flip of a switch (or toggle)!", MenuButtonClicked);
            _mainFlowCoordinator = mainFlowCoordinator;
            _stFlowCoordinator = stFlowCoordinator;
        }

        public void Initialize()
        {
            MenuButtons.instance.RegisterButton(_menuButton);
        }

        public void Dispose()
        {
            if (MenuButtons.IsSingletonAvailable)
                MenuButtons.instance.UnregisterButton(_menuButton);
        }

        private void MenuButtonClicked()
        {
            _mainFlowCoordinator.PresentFlowCoordinator(_stFlowCoordinator);
        }
    }
}