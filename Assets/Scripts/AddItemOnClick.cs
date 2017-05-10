using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;

public class AddItemOnClick : MonoBehaviour
{
    public Armor RuntimeArmor;
    public Armor armor;
    public Armor RuntimeBrock;
    public Armor Brock;
    public Weapon RuntimeWeapon;
    public Weapon Knife;
    public CharacterInventory Inventory;
    void Start()
    {
        Inventory = GetComponent<CharacterInventory>();
        RuntimeArmor = Instantiate(armor);
        RuntimeArmor.Initialize(gameObject);
        RuntimeBrock = Instantiate(Brock);
        RuntimeBrock.Initialize(gameObject);
        RuntimeWeapon = Instantiate(Knife);
        RuntimeWeapon.Initialize(gameObject);


    }

    public void DoClick()
    {
        Inventory.EquipWeapon(Knife);
        Inventory.EquipArmor(RuntimeArmor);
        Inventory.EquipArmor(RuntimeBrock);

    }

}
