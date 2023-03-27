using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

/*
 * Cooper Denault
 * Skeleton
 * Assignemnt 8 Easy
 * Subclass for skeleton that sets values
 */



public class Skeleton : MonsterSuperClass
{
    int attack;
    int speed;


    public override int GetMonsterAttack()
    {
        attack = Random.Range(25, 50);

        return attack;
    }

    public override int GetMonsterSpeed()
    {
        speed = Random.Range(20, 50);

        return speed;
    }
}


