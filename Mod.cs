using Colossal.Logging;
using Game;
using Game.Modding;
using Game.SceneFlow;

namespace ResidentialServiceBuildingPack
{
    public class Mod : IMod
    {
        public static ILog log = LogManager.GetLogger($"{nameof(ResidentialServiceBuildingPack)}.{nameof(Mod)}")
            .SetShowsErrorsInUI(false);

        public void OnLoad(UpdateSystem updateSystem)
        {
            log.Info("Loading Asset Pack " + nameof(ResidentialServiceBuildingPack));
        }

        public void OnDispose()
        {
        }
    }
}