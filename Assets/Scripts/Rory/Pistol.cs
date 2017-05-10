﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item/Weapon/Pistol")]
public class Pistol : Weapon
{
    public Sprite Bullet;
    public string Rory;

    public override void Initialize(GameObject obj)
    {
        throw new System.NotImplementedException();
    }

    public override void Execute(GameObject a)
    {
        
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
