using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Cooper Denault
 * ObjectiveStats
 * Assignment 3
 * Makes interface for observers to update the data
 */

public interface Observer
{
    void UpdateData(List<Objective> objectives);
}
