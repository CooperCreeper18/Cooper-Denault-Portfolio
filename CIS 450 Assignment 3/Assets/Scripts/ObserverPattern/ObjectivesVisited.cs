using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Cooper Denault
 * ObjectiveStats
 * Assignment 3
 * allows printing of the data
 */
public class ObjectivesVisited : MonoBehaviour, Observer
{
    public ObjectiveStats objectiveStats;

    private string textForDisplay;

    // Start is called before the first frame update
    void Start()
    {
        textForDisplay = gameObject.GetComponent<Text>().text;
        objectiveStats.RegisterObserver(this);
    }

    public void UpdateData(List<Objective> objectives)
    {
        textForDisplay = "";
        foreach (Objective objective in objectives)
        {
            textForDisplay += "Location: " + objective.objectiveName + ".\n";
            textForDisplay += "Reached: " + objective.objectiveReached.ToString() + ".\n";
            textForDisplay += "Score for reaching: " + objective.score.ToString() + ".\n\n";
        }
        textForDisplay += "Total Experience: " + objectiveStats.totalScore.ToString() + ".\n";
        gameObject.GetComponent<Text>().text = this.textForDisplay;
    }
}
