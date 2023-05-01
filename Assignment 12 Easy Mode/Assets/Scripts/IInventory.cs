using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInventory
{
    string Name { get; set; }
    void PrintName();
}