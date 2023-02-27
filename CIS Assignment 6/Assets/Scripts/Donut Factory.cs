using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DonutFactory : DesertFactory
{
    public override Dessert CreateDessert(Dessert type)
    {
        Dessert dessert1 = new SmallDonut();
        Dessert dessert2 = new LargeDonut();

        float smallcal = Random.Range(0, 10);
        float smalltaste = Random.Range(30, 40);

        float largecal = Random.Range(40, 50);
        float largetaste = Random.Range(70, 80);


        if (type is SmallDonut)
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
