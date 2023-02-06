using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : MonoBehaviour
{

    public string objectiveName;
    public bool objectiveReached;
    public int score;

    public Vector3 objectivePosition;

    public ObjectiveStats objectiveArea;


    // Start is called before the first frame update
    void Start()
    {
        objectivePosition = gameObject.transform.position;
        objectiveArea.AddObjective(this);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag =="Player" && objectiveReached == false)
        {
            objectiveReached = true;
            objectiveArea.totalScore += this.score;
            objectiveArea.NotifyObservers();
        }
    }


}
