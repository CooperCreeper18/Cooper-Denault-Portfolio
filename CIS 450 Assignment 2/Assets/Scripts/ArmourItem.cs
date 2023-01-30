using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmourItem : Items, IUsingItem
{
    public override void Use()
    {
        Destroy(gameObject);
    }
}
