using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
		 * Cooper Denault
		 * Backpack
		 * (Assignment 12)
		 * Makes the backback and the ability to add or remove items
*/


public class Backpack : IInventory, IEnumerable<IInventory>
{
    private List<IInventory> _subordinates = new List<IInventory>();

    public string Name { get; set; }

    public void AddSubordinate(IInventory subordinate)
    {
        _subordinates.Add(subordinate);
    }

    public void RemoveSubordinate(IInventory subordinate)
    {
        _subordinates.Remove(subordinate);
    }

    public IInventory GetSubordinate(int index)
    {
        return _subordinates[index];
    }

    public string PrintName()
    {
        return Name;
    }
    public IEnumerator<IInventory> GetEnumerator()
    {
        foreach (IInventory subordinate in _subordinates)
        {
            yield return subordinate;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}