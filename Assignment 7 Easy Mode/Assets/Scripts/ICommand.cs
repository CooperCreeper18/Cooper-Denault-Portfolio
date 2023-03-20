using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Cooper Denault
 * ClickCommand
 * Assignment 7 Easy
 * This play the command to play the sequence and also undue the sequence
 */


public interface ICommand
{
    void Execute();
    void Undue();
}
