using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item/Potion/Mana")]
public class ManaPotion : Potion
{

    private int Mana;

    public override void Initialize(GameObject obj)
    {
        this.GUID = this.GetHashCode();
        this.Name = Prefix + " " + this.Name;
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
