using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Cooper Denault
 * ObjectiveStats
 * Assignment 3
 * Sets subject object
 */

public interface Subject 
{
    void RegisterObserver(Observer observer);
    void RemoveObserver(Observer observer);
    void NotifyObservers();
}
