using UnityEngine;
using System.Collections;

/*
 *Cooper Denault
 * Skeleton
 * Assignemnt 9 Easy
 * This class creates the skeleton enemy and sets the subvalues for its different states to do the different actions.
 */



public class Skeleton : EnemyType
{
    Enemy skeletonMode = Enemy.Stroll;

    float health = 100f;


    public Skeleton(Transform skeletonObj)
    {
        base.enemyObj = skeletonObj;
    }


    //Update the skeleton state state
    public override void UpdateEnemy(Transform playerObj)
    {
        //The distance between the skeleton and the player
        float distance = (base.enemyObj.position - playerObj.position).magnitude;

        switch (skeletonMode)
        {
            case Enemy.Attack:
                if (health < 20f)
                {
                    skeletonMode = Enemy.Flee;
                }
                else if (distance > 6f)
                {
                    skeletonMode = Enemy.MoveTowardsPlayer;
                }
                break;
            case Enemy.Flee:
                if (health > 60f)
                {
                    skeletonMode = Enemy.Stroll;
                }
                break;
            case Enemy.Stroll:
                if (distance < 10f)
                {
                    skeletonMode = Enemy.MoveTowardsPlayer;
                }
                break;
            case Enemy.MoveTowardsPlayer:
                //The skeleton has bow and arrow so can attack from distance
                if (distance < 5f)
                {
                    skeletonMode = Enemy.Attack;
                }
                else if (distance > 15f)
                {
                    skeletonMode = Enemy.Stroll;
                }
                break;
        }

        //Move the enemy based on a state
        DoAction(playerObj, skeletonMode);
    }
}