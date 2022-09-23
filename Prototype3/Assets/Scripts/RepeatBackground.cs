using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Cooper Denault
 * Prototype 3
 * Makes it so the background repeats
 */
public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPosition;
    private float repeatWidth;
   
    // Start is called before the first frame update
    void Start()
    {
        //save starting position as a Vector3
        startPosition = transform.position;

        //set the repeatWidth to half of the width of the background
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        //if teh background is farther to the leftthan the repeatWidt, reset it to its str=art position
        if (transform.position.x < startPosition.x - repeatWidth)
        {
            transform.position = startPosition;
        }
    }
}
