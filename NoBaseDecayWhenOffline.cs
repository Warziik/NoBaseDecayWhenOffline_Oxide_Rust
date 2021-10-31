using Rust;

namespace Oxide.Plugins
{
    [Info("NoBaseDecayWhenOffline", "Warziik", "0.1.0")]
    [Description("Disable base decaying when all players allowed on a tool cupboard are offline.")]
    class NoBaseDecayWhenOffline: CovalencePlugin
    {
        void init()
        {
            Puts("NoBaseDecayWhenOffline init");
        }

        object OnEntityTakeDamage(BaseCombatEntity entity, HitInfo info)
        {
            if (info == null || info.damageTypes == null || entity == null || !info.damageTypes.Has(DamageType.Decay)) return null;

            BuildingPrivlidge buildingPrivlidge = entity.GetBuildingPrivilege();
            if (buildingPrivlidge == null || !buildingPrivlidge.AnyAuthed()) return null;
            
            BasePlayer player = BasePlayer.Find(entity.OwnerID.ToString());
            if (player != null)
            {
                if (player.IsConnected) return null;
                else return true;
            }

            return null;
        }
    }
}