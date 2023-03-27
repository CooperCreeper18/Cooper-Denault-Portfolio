using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Cooper Denault
 * SkeletonText
 * Assignemnt 8 Easy
 * class for the text object for skelleton
 */



public class SkeletonText : MonoBehaviour
{
    // Start is called before the first frame update

    private string skelletonTextDisplay;


    void Start()
    {
        skelletonTextDisplay = gameObject.GetComponent<Text>().text;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            MonsterSuperClass Bones = new Skeleton();
            Bones.Template();

            skelletonTextDisplay = "This Skeleton Attacks for " + Bones.GetMonsterAttack() + " Damage.\n";
            skelletonTextDisplay += "This Skeleton Moves for " + Bones.GetMonsterSpeed() + " Speed.";

        }
        gameObject.GetComponent<Text>().text = skelletonTextDisplay;
    }
}
