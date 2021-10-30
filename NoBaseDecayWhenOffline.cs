using System;
using Oxide.Core.Libraries.Covalence;
using Oxide.Plugins;

namespace Oxide.Plugins
{
    [Info("NoBaseDecayWhenOffline", "Warziik", "0.1.0")]
    [Description("Disable base decaying when all players allowed on tool cupboard are offline.")]
    class NoBaseDecayWhenOffline: CovalencePlugin
    {
        private void init()
        {
            Puts("NoBaseDecayWhenOffline init");
        }
    }
}
