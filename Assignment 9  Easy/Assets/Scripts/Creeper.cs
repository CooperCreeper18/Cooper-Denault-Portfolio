using UnityEngine;
using System.Collections;

/*
 * Cooper Denault
 * Creeper
 * Assignemnt 9 Easy
 * This class creates the creeper enemy and sets the subvalues for its different states to do the different actions.
 */

public class Creeper : EnemyType
{
    Enemy creeperMode = Enemy.Stroll;

    float health = 100f;


    public Creeper(Transform creeperObj)
    {
        base.enemyObj = creeperObj;
    }


    //Update the creeper's state
    public override void UpdateEnemy(Transform playerObj)
    {
        //The distance between the Creeper and the player
        float distance = (base.enemyObj.position - playerObj.position).magnitude;

        switch (creeperMode)
        {
            case Enemy.Attack:
                if (health < 20f)
                {
                    creeperMode = Enemy.Flee;
                }
                else if (distance > 2f)
                {
                    creeperMode = Enemy.MoveTowardsPlayer;
                }
                break;
            case Enemy.Flee:
                if (health > 60f)
                {
                    creeperMode = Enemy.Stroll;
                }
                break;
            case Enemy.Stroll:
                if (distance < 10f)
                {
                    creeperMode = Enemy.MoveTowardsPlayer;
                }
                break;
            case Enemy.MoveTowardsPlayer:
                if (distance < 1f)
                {
                    creeperMode = Enemy.Attack;
                }
                else if (distance > 15f)
                {
                    creeperMode = Enemy.Stroll;
                }
                break;
        }

        //Move the enemy based on a state
        DoAction(playerObj, creeperMode);
    }
}