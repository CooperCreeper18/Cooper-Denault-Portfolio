using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class smalldonuttext : MonoBehaviour
{
    Dessert dessert2 = new SmallDonut();

    DonutFactory donutFactory = new DonutFactory();

    private string textForDisplay;

    // Start is called before the first frame update
    void Start()
    {
        textForDisplay = gameObject.GetComponent<Text>().text;

        textForDisplay = "The small donut has " + dessert2.calories + " and a taste factor of " + dessert2.taste;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            donutFactory.CreateDessert(dessert2);
            textForDisplay = "The small donut has " + donutFactory.CreateDessert(dessert2).calories + " and a taste factor of " + donutFactory.CreateDessert(dessert2).taste;
        }

        gameObject.GetComponent<Text>().text = this.textForDisplay;
    }
}
