using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyItem : Items, IUsingItem
{

    public override void Use()
    {

        Destroy(gameObject);

    }

    

}
