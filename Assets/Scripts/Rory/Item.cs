using System;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public abstract class Item : ScriptableObject, IExecutable<GameObject>
{
    public int GUID;
    public string Name;
    public Sprite sprite;
    protected GameObject owner;
    public abstract void Initialize(GameObject obj);
    public abstract void Execute(GameObject obj);

}
public abstract class Weapon : Item, IEquippable
{
    public int Damage;
    public abstract InventorySlot TargetSlot { get; set; }
    public abstract bool Equip(InventorySlot targetSlotRequest);
    public abstract void UnEquip();

}
public abstract class Armor : Item, IEquippable
{
    
    public int AC;
    public abstract InventorySlot TargetSlot { get; set; }
    public abstract bool Equip(InventorySlot targetSlotRequest);
    public abstract void UnEquip();
}


public abstract class Potion : Item
{
    public enum PotionPrefix
    {
        Light,
        Medium,
        Strong,
    }
    public PotionPrefix Prefix;
    public abstract InventorySlot TargetSlot { get; set; }
    public abstract bool Equip(InventorySlot targetSlotRequest);
    public abstract void UnEquip();
}

public enum InventorySlot
{
    Head,
    Necklace,
    Shoulder,
    Torso,
    Wrist,
    Legs,
    Feet,
    OffHand,
    MainHand,


}
public interface IEquippable
{
    InventorySlot TargetSlot { get; set; }
    bool Equip(InventorySlot targetSlot);
    void UnEquip();
}

interface IExecutable<T>
{
    void Execute(T obj);
}
