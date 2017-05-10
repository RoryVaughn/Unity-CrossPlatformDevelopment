using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIInventorySlot : MonoBehaviour
{
    public InventorySlot thisSlot;

    void Start()
    {
        FindObjectOfType<CharacterInventory>().onArmorEquipped.AddListener(SetArmor);    
        FindObjectOfType<CharacterInventory>().onWeaponEquipped.AddListener(SetWeapon);
    }

    public void SetArmor(Armor armor)
    {
        if (armor.TargetSlot != thisSlot)
            return;

        Sprite armorSprite = armor.sprite;
        GetComponent<UnityEngine.UI.Image>().sprite = armorSprite;
    }
    public void SetWeapon(Weapon weapon)
    {
        if (weapon.TargetSlot != thisSlot)
            return;

        Sprite weaponSprite = weapon.sprite;
        GetComponent<UnityEngine.UI.Image>().sprite = weaponSprite;
    }

}
