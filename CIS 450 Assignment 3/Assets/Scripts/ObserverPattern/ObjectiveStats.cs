using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static UnityEditor.FilePathAttribute;

/*
 * Cooper Denault
 * ObjectiveStats
 * Assignment 3
 * Makes list of observers and modifies the data in them
 */


public class ObjectiveStats : ScriptableObject, Subject
{
    private List<Observer> observers = new List<Observer>();

    public List<Objective> objectives = new List<Objective>();

    public int totalScore;

    private void OnEnable()
    {
        totalScore = 0;
    }

    public void RegisterObserver(Observer observer)
    {
        //Add observer to list of observers
        observers.Add(observer);

        if (objectives != null)
        {
            //Updates data for newly added observer
            observer.UpdateData(objectives);
        }

    }

    public void RemoveObserver(Observer observer)
    {
        if (observers.Contains(observer))
        {
            observers.Remove(observer);
        }
    }

    public void NotifyObservers()
    {
        foreach (Observer observer in observers)
        {
            //include data as parameters to UpdateData
            observer.UpdateData(objectives);

        }
    }

    public void AddObjective(Objective objective)
    {
        //Add location to list of locations
        objectives.Add(objective);

        NotifyObservers();
    }
}
