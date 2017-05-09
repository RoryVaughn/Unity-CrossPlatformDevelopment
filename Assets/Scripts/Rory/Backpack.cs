using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Backpack : MonoBehaviour {


    int space;
    public List<Item> InspectorItems;
    public List<Item> Items;
    public GameObject itemBehaviour;

    // Use this for initialization
    void Start () {

        foreach (var item in InspectorItems)
        {
            var runtimeItem = Instantiate(item);
            Items.Add(runtimeItem);        
        }

        itemBehaviour.GetComponent<SpriteRenderer>().sprite = Items[3].sprite;
    }

    
	
	// Update is called once per frame
	void Update () {
	

    }
}
