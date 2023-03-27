using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Cooper Denault
 * ZombieText
 * Assignemnt 8 Easy
 * class for the text object for zombie
 */




public class ZombieText : MonoBehaviour
{
    // Start is called before the first frame update

    private string zombieTextDisplay;

    void Start()
    {
        zombieTextDisplay = gameObject.GetComponent<Text>().text;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            MonsterSuperClass Dave = new Zombie();
            Dave.Template();

            zombieTextDisplay = "This Zombie Attacks for " + Dave.GetMonsterAttack() + " Damage.\n";
            zombieTextDisplay += "This Zombie Moves for " + Dave.GetMonsterSpeed() + " Speed.";

        }
        gameObject.GetComponent<Text>().text = zombieTextDisplay;
    }
}
