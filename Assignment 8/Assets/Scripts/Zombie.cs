using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEditorInternal.ReorderableList;

/*
 * Cooper Denault
 * Zombie
 * Assignemnt 8 Easy
 * Subclass for zombie that sets values
 */


public class Zombie : MonsterSuperClass
{
    int attack;
    int speed;

    public override int GetMonsterAttack()
    {
        attack = Random.Range(50, 100);

        return attack;
    }

    public override int GetMonsterSpeed()
    {
        speed = Random.Range(5, 20);

        return speed;
    }
}
