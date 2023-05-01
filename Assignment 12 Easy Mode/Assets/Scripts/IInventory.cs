using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/*
		 * Cooper Denault
		 * Backpack
		 * (Assignment 12)
		 * Simplifies the inventory anf getting the name of the items from them.
*/

public interface IInventory
{
    string Name { get; set; }

    string PrintName();
}