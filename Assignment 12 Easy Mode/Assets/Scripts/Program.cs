using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Program
{
    static void Main(string[] args)
    {
        Backpack inventory = new Backpack { Name = "Inventory" };
        Backpack backpack = new Backpack { Name = "Backpack" };

        inventory.AddSubordinate(backpack);
        inventory.AddSubordinate(new Item { Name = "Sword" });
        inventory.AddSubordinate(new Item { Name = "Armor" });

        backpack.AddSubordinate(new Item { Name = "Shield" });

        Console.WriteLine("List of items in inventory");

        foreach (IInventory element in inventory)
        {
            element.PrintName();
        }
        Console.ReadKey();
    }
}