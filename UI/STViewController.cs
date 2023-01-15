using BeatSaberMarkupLanguage;
using BeatSaberMarkupLanguage.Attributes;
using BeatSaberMarkupLanguage.Components;
using BeatSaberMarkupLanguage.ViewControllers;
using BeatSaberMarkupLanguage.MenuButtons;
using System;
using HMUI;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using UnityEngine;
using ScoreToggler.Configuration;

namespace ScoreToggler.UI
{
    [HotReload(RelativePathToLayout = @"./STSettingsView.bsml")]
    [ViewDefinition("ScoreToggler.UI.STSettingsView.bsml")]
    internal class STFlowCoordinator : BSMLAutomaticViewController
    {
		private SiraLog _siraLog = null!;
		private PluginConfig _pluginConfig = null!;
		private PluginMetadata _pluginMetadata = null!;
		private ISiraSyncService _siraSyncService = null!;
		
		[In]
	}
}