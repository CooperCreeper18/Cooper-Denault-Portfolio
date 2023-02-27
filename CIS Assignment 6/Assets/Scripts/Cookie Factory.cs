using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class CookieFactory : DesertFactory
{
    public override Dessert CreateDessert(Dessert type)
    {
        Dessert dessert1 = new SmallCookie();
        Dessert dessert2 = new LargeCookie();

        float smallcal = Random.Range(10, 20);
        float smalltaste = Random.Range(50, 60);

        float largecal = Random.Range(50, 60);
        float largetaste = Random.Range(90, 100);


        if (type is SmallCookie)
        {
            dessert1.calories = smallcal;
            dessert1.taste = smalltaste;

            return dessert1;
        }
        else
        {
            dessert2.calories = largecal;
            dessert2.taste = largetaste;

            return dessert2;
        }


    }
}
