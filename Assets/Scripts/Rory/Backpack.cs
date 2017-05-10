using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Backpack : MonoBehaviour
{

    int space;
    public List<Item> InspectorItems;
    public List<Item> Items;
    public GameObject item_GameObject;

    public Item InspectorArmorItem;
    private Item ArmorItem;

    public Item InspectorPotionItem;
    private Item PotionItem;

    public int currentitem;


    // Use this for initialization
    void Start()
    {
        SetPotion();
        SetArmor();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentitem++;
            if (currentitem >= Items.Count)
            {
                currentitem = 0;
            }
            item_GameObject.GetComponent<SpriteRenderer>().sprite = Items[currentitem].sprite;

        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            SetArmor();
        }
    }

    void SetArmor()
    {
        ArmorItem = Instantiate(InspectorArmorItem);
        ArmorItem.Initialize(gameObject);
        Items.Add(ArmorItem);
        item_GameObject.GetComponent<SpriteRenderer>().sprite = ArmorItem.sprite;
    }
    void SetPotion()
    {
        PotionItem = Instantiate(InspectorPotionItem);
        PotionItem.Initialize(gameObject);
        Items.Add(PotionItem);
        item_GameObject.GetComponent<SpriteRenderer>().sprite = PotionItem.sprite;
    }




}
