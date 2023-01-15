using BeatSaberMarkupLanguage.Attributes;
using BeatSaberMarkupLanguage.ViewControllers;
using HMUI;
using IPA.Loader;
using SiraUtil.Logging;
using SiraUtil.Web.SiraSync;
using SiraUtil.Zenject;
using Tweening;
using UnityEngine;
using Zenject;
using BeatSaberMarkupLanguage.Components.Settings;
using IPA.Utilities;
using UnityEngine.UI;
using System;
using SiraUtil.Submissions;
using BS_Utils.Gameplay;
using ScoreToggler.Configuration;

namespace ScoreToggler.UI.ViewController
{
	[HotReload(RelativePathToLayout = @"./STSettingsView.bsml")]
	[ViewDefinition("ScoreToggler.UI.STSettingsView.bsml")]
	internal class STViewController : BSMLAutomaticViewController
	{
		private SiraLog _siraLog = null!;
		private STConfig _pluginConfig = null!;
		private PluginMetadata _pluginMetadata = null!;
		private ISiraSyncService _siraSyncService = null!;

		[Inject]
		private void Construct(SiraLog siraLog, STConfig pluginConfig, UBinder<Plugin, PluginMetadata> pluginMetadata, ISiraSyncService siraSyncService)
        {
			_siraLog = siraLog;
			_pluginConfig = pluginConfig;
			_pluginMetadata = pluginMetadata.Value;
			_siraSyncService = siraSyncService;
        }

		[UIValue("scores-enabled")]
		private bool ScoresEnabled
        {
			get => _pluginConfig.scoresEnabled;
            set
            {
				_pluginConfig.scoresEnabled = value;
				if (value == false)
                {
					ScoreSubmission.DisableSubmission("Score Toggler");
                }
				NotifyPropertyChanged();
            }
        }
	}
}