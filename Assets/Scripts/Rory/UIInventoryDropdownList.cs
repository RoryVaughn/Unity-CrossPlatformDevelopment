using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;


public class UIInventoryDropdownList : MonoBehaviour {

    public Armor RuntimeChest;
    public Armor RuntimeHelmet;
    public Armor RuntimeLegs;
    public Weapon RuntimeWeapon;

    public Armor armorConfig;
    public Armor helmetConfig;
    public Armor legsConfig;
    public Weapon Knife;
    public List<Armor> armorList;
    public List<Weapon> weaponsList;
    public CharacterInventory Inventory;
    public Dropdown dropdown;

    void Start()
    {
        Inventory = FindObjectOfType<CharacterInventory>();
        RuntimeChest = Instantiate(armorConfig);
        RuntimeHelmet = Instantiate(helmetConfig);
        RuntimeLegs = Instantiate(legsConfig);
        RuntimeWeapon = Instantiate(Knife);
        armorList = new List<Armor> { RuntimeChest, RuntimeHelmet, legsConfig };
        weaponsList = new List<Weapon> { RuntimeWeapon};
        weaponsList.ForEach(w => w.Initialize(gameObject));
        armorList.ForEach(a => a.Initialize(gameObject));
        dropdown = GetComponent<Dropdown>();
    }


    public void SendInventory(int id)
    {
        var allitems = new List<IEquippable>();
        foreach (var a in armorList)
        {
            allitems.Add(a);
        }
        foreach (var w in weaponsList)
        {
            allitems.Add(w);
        }
        var armortosend = allitems.First(a => (int) a.TargetSlot == id);
        var armor = armortosend as Armor;
        var weapon = armortosend as Weapon;
        if(weapon == null)            
            Inventory.EquipArmor(armor);
        else if (armor == null)
            Inventory.EquipWeapon(weapon);
    }
    
    void OnEnable()
    {
        
        dropdown = GetComponent<Dropdown>();
        dropdown.ClearOptions();
        var enums = Enum.GetNames(typeof(InventorySlot)).ToList();

        foreach (var e in enums)
        {
            var item = new Dropdown.OptionData(e);
            dropdown.options.Add(item);
        }
    }

    private void OnDisable()
    {
        dropdown = GetComponent<Dropdown>();
        dropdown.ClearOptions();
    }
}
