using SDG.Unturned;
using System.Linq;
using HarmonyLib;
using Rocket.Unturned.Player;
using UnityEngine;

namespace SprayPaint.Patches
{
    [HarmonyPatch(typeof(UseableMelee), "fire")]
    public static class MeleeUsePatch
    {
        [HarmonyPrefix]
        internal static void OnPlayerAttackInvoker(UseableMelee __instance)
        {
            var nativePlayer = __instance.player;
            var player = UnturnedPlayer.FromPlayer(nativePlayer);

            if (player == null) return;

            if (!Physics.Raycast(new Ray(player.Player.look.aim.position, player.Player.look.aim.forward), out var hit, 10f, RayMasks.VEHICLE)) return;

            if (hit.transform.GetComponent<InteractableVehicle>() == null) return;

            if (player.Player.equipment.itemID == 0 || !Main.Instance.Configuration.Instance.Vehicles
                                                 .Any(vehicle => vehicle.PaintID == player.Player.equipment.itemID && vehicle.BaseVehicleID == hit.transform.GetComponent<InteractableVehicle>().id)) return;

            var new_vehicle =
                Main.Instance.Configuration.Instance.Vehicles.FirstOrDefault(vehicle =>
                    vehicle.PaintID == player.Player.equipment.itemID && vehicle.BaseVehicleID == hit.transform.GetComponent<InteractableVehicle>().id);

            if (new_vehicle == null) return;

            var old_vehicle = hit.transform.GetComponent<InteractableVehicle>();

            old_vehicle.trunkItems.clear();
            VehicleManager.askVehicleDestroy(old_vehicle);

            var intractable_new = VehicleManager.SpawnVehicleV3(
                Assets.find(EAssetType.VEHICLE, new_vehicle.PaintedVehicleID) as VehicleAsset, old_vehicle.skinID,
                old_vehicle.mythicID,
                old_vehicle.roadPosition, old_vehicle.transform.position, old_vehicle.transform.localRotation,
                old_vehicle.sirensOn, old_vehicle.isBlimpFloating, old_vehicle.headlightsOn,
                old_vehicle.taillightsOn,
                old_vehicle.fuel, old_vehicle.health, old_vehicle.batteryCharge, old_vehicle.lockedOwner,
                old_vehicle.lockedGroup, old_vehicle.isLocked, null, old_vehicle.tireAliveMask);
            

            for(var i = 0; i <= old_vehicle.trunkItems.items.Count - 1; i++)
            {
                var old_vehicle_item = old_vehicle.trunkItems.items[i];
                
                intractable_new.trunkItems.addItem(old_vehicle_item.x, old_vehicle_item.y, old_vehicle_item.rot, old_vehicle_item.item);
            }
        }
    }
}
