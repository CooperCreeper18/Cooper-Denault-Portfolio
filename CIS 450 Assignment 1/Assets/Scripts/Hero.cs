using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Cooper Denault
 * Console Output
 * Assignment 1
 * Makes super class type hero
 */

public abstract class Hero
{
    private int age;
    private int weight;
    private string name;

    public void Move()
    {
        Debug.Log("This hero is moving.");
    }

    public abstract void AttackPower();

    public void setAge(int newAge)
    {
        if (age > 0)
        {
            age = newAge;
        }
        else
        {
            Debug.Log("Age must be greater than 0.");
        }
    }

    public int getAge()
    {
        return age;
    }


    public void setWeight(int newWeight)
    {
        if (weight > 0)
        {
            weight = newWeight;
        }
        else
        {
            Debug.Log("Weight must be greater than 0.");
        }
    }

    public int getWeight()
    {
        return weight;
    }

    public void setName(string newName)
    {
        name = newName;
    }

    public string getName()
    {
        return name;
    }
}
