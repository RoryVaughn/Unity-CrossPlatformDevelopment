using UnityEngine;
using System.Collections;

[CreateAssetMenu(menuName ="Item/Weapon/Knives")]
public class CombatKnife : Weapon {

    // Use this for initialization
    public string Rory;
    public override void Initialize(GameObject obj)
    {
        this.GUID = this.GetHashCode();
        TargetSlot = InventorySlot.MainHand;
    }

    public override void Execute(GameObject a)
    {
        throw new System.NotImplementedException();
    }

    public override InventorySlot TargetSlot { get; set; }
    public override bool Equip(InventorySlot targetSlotRequest)
    {
        if (targetSlotRequest != TargetSlot)
        {
            Debug.LogWarning("trying to add an equippable item to the wrong slot");
            return false;
        }

        return true;
    }

    public override void UnEquip()
    {
        throw new System.NotImplementedException();
    }
}
