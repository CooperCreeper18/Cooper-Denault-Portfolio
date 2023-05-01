using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : IInventory
{
    public string Name { get; set; }

    public void PrintName()
    {
        Debug.Log(Name);
    }
}