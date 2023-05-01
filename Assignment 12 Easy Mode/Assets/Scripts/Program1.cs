using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;



/*
		 * Cooper Denault
		 * Backpack
		 * (Assignment 12)
		 * Adding items to the inventory
*/

public class Program1 : MonoBehaviour
{

    private string text;

    Backpack inventory = new Backpack { Name = "Inventory" };
    Backpack backpack = new Backpack { Name = "Backpack" };

    // Start is called before the first frame update
    void Start()
    {
        Backpack inventory = new Backpack { Name = "Inventory" };
        Backpack backpack = new Backpack { Name = "Backpack" };

        text = gameObject.GetComponent<Text>().text;

        inventory.AddSubordinate(backpack);


    }

    public void ButtonPress1()
    {
        inventory.AddSubordinate(new Item { Name = "Sword" });

        text +=  " Sword ";
    }

    public void ButtonPress2()
    {
        inventory.AddSubordinate(new Item { Name = "Armor" });

        text += " Armour ";



    }



    // Update is called once per frame
    void Update()
    {
    

        gameObject.GetComponent<Text>().text = text;
    }
}

