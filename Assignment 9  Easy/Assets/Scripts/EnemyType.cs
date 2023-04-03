using UnityEngine;
using System.Collections;

/*
 * Cooper Denault
 * Enemy Type
 * Assignemnt 9 Easy
 * This class creates the enemy super type and sets the different states it can be in the enum method
 */



public class EnemyType
{
    protected Transform enemyObj;

    //The different states the enemy can be in
    protected enum Enemy
    {
        Attack,
        Flee,
        Stroll,
        MoveTowardsPlayer
    }


    //Update the enemy by giving it a new state
    public virtual void UpdateEnemy(Transform playerObj)
    {

    }


    //Do something based on a state
    protected void DoAction(Transform playerObj, Enemy enemyMode)
    {
        float fleeSpeed = 10f;
        float strollSpeed = 1f;
        float attackSpeed = 5f;

        switch (enemyMode)
        {
            case Enemy.Attack:
                //Attack player
                break;
            case Enemy.Flee:
                //Move away from player
                //Look in the opposite direction
                enemyObj.rotation = Quaternion.LookRotation(enemyObj.position - playerObj.position);
                //Move
                enemyObj.Translate(enemyObj.forward * fleeSpeed * Time.deltaTime);
                break;
            case Enemy.Stroll:
                //Look at a random position
                Vector3 randomPos = new Vector3(Random.Range(0f, 100f), 0f, Random.Range(0f, 100f));
                enemyObj.rotation = Quaternion.LookRotation(enemyObj.position - randomPos);
                //Move
                enemyObj.Translate(enemyObj.forward * strollSpeed * Time.deltaTime);
                break;
            case Enemy.MoveTowardsPlayer:
                //Look at the player
                enemyObj.rotation = Quaternion.LookRotation(playerObj.position - enemyObj.position);
                //Move
                enemyObj.Translate(enemyObj.forward * attackSpeed * Time.deltaTime);
                break;
        }
    }
}