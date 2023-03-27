using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Cooper Denault
 * MonsterSuperClass
 * Assignemnt 8 Easy
 * Super Class for subclass objects
 */


public abstract class MonsterSuperClass
{

    public abstract int GetMonsterAttack();
    public abstract int GetMonsterSpeed();


    public void Template()
    {
        GetMonsterAttack();
        GetMonsterSpeed();
    }
    
}
