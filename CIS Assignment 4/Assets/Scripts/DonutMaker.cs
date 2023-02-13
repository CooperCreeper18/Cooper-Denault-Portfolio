using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * (Cooper Denault)
 * (Donut)
 * (Assignment)
 * (Allows the buttons to access the scripts which change the text)
 */


public class DonutMaker : MonoBehaviour
{
    public Donut donut;

    public void SetDonut(string typeDonut)
    {
        switch (typeDonut)
        {
            case "Long John Donut":
                this.donut = new LongJohnDonut();
                break;

            case "Frosted Donut":
                this.donut = new FrostedDonut();
                break;

            case "Glazed Donut":
                this.donut = new GlazedDonut();
                break;

            case "Jelly Donut":
                this.donut = new JellyDonut();
                break;
        }

        DisplayDonut();
    }


    public void AddTopping(string newTopping)
    {
        switch (newTopping)
        {
            case "Coconut":
                this.donut = new ToppingCoconut(donut);
                break;

            case "Nuts":
                this.donut = new ToppingNuts(donut);
                break;

            case "Cinnamon":
                this.donut = new ToppingCinnamon(donut);
                break;

            case "Sprinkles":
                this.donut = new ToppingSprinkles(donut);
                break;
        }

        DisplayDonut();
    }


    public void DisplayDonut()
    {
        gameObject.GetComponent<Text>().text = donut.getDescription() + " with " + donut.getSugarAmount() + " sugar.";
    }



}
