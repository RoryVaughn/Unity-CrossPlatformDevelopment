using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item/Armor/Pants")]
public class Pants : Armor
{

    public enum ArmorSuffix
    {
        Armadillo,
        Tiger,
        Bear,
    }


    public ArmorSuffix Suffix;
    public override void Initialize(GameObject obj)
    {
        owner = obj;
        this.GUID = this.GetHashCode();
        this.Name += " of the " + Suffix;
        TargetSlot = InventorySlot.Legs;
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
