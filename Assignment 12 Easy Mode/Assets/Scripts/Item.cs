using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
		 * Cooper Denault
		 * Backpack
		 * (Assignment 12)
		 * What the items have in store for them.
*/

public class Item : IInventory
{
    public string Name { get; set; }

	public string PrintName()
	{
		return Name;
	}
}