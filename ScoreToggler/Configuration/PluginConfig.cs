using System.Runtime.CompilerServices;
using IPA.Config.Stores;

[assembly: InternalsVisibleTo(GeneratedStore.AssemblyVisibilityTarget)]
namespace ScoreToggler.Configuration
{
    internal class STConfig
    {
        public static STConfig Instance { get; set; }

        public bool scoresEnabled = true;
    }
}