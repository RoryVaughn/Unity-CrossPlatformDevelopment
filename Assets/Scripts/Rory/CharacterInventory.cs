using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CharacterInventory : MonoBehaviour
{
    [System.Serializable]
    public class OnArmorEquipped : UnityEvent<Armor> { }
    [System.Serializable]
    public class OnWeaponEquipped : UnityEvent<Weapon> { }

    [SerializeField]
    public OnArmorEquipped onArmorEquipped = new OnArmorEquipped();
    public OnWeaponEquipped onWeaponEquipped = new OnWeaponEquipped();
    public List<IEquippable> Equippables;
    public const InventorySlot HeadSlot = InventorySlot.Head;
    public const InventorySlot NecklaceSlot = InventorySlot.Necklace;
    public const InventorySlot ShoulderSlot = InventorySlot.Shoulder;
    public const InventorySlot TorsoSlot = InventorySlot.Torso;
    public const InventorySlot WristSlot = InventorySlot.Wrist;
    public const InventorySlot LegsSlot = InventorySlot.Legs;
    public const InventorySlot FeetSlot = InventorySlot.Feet;
    public const InventorySlot MainHandSlot = InventorySlot.MainHand;
    public const InventorySlot OffHandSlot = InventorySlot.OffHand;

    public Armor currentHead;
    public Armor currentNecklace;
    public Armor currentShoulder;
    public Armor currentTorso;
    public Armor currentWrist;
    public Armor currentLegs;
    public Armor currentFeet;
    public Weapon currentMainHand;
    public Weapon currentOffHand;

    /// <summary>
    /// equip the armor and try to assign it to the appropriate inventory slot
    /// </summary>
    /// <param name="equippable"></param>
    public void EquipArmor(Armor equippable)
    {
        Debug.LogFormat("try to equip {0} in slot {1}", equippable, equippable.TargetSlot);
        if (equippable.Equip(equippable.TargetSlot))
        {
            switch (equippable.TargetSlot)
            {
                case HeadSlot:
                    currentHead = equippable;
                    break;
                case NecklaceSlot:
                    currentNecklace = equippable;
                    break;
                case ShoulderSlot:
                    currentShoulder = equippable;
                    break;
                case TorsoSlot:
                    currentTorso = equippable;
                    break;
                case WristSlot:
                    currentWrist = equippable;
                    break;
                case LegsSlot:
                    currentLegs = equippable;
                    break;
                case FeetSlot:
                    currentFeet = equippable;
                    break;
            }
            onArmorEquipped.Invoke(equippable);
        }
    }

    public void EquipWeapon(Weapon equippable)
    {
        if (equippable.Equip(equippable.TargetSlot))
        {
            switch (equippable.TargetSlot)
            {
                case MainHandSlot:
                    currentMainHand = equippable;
                    break;
                case OffHandSlot:
                    currentOffHand = equippable;
                    break;
            }
            onWeaponEquipped.Invoke(equippable);
        }
    }
}

