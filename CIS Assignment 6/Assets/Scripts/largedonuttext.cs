using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class largedonuttext : MonoBehaviour
{
    Dessert dessert4 = new LargeDonut();

    DonutFactory cookieFactory = new DonutFactory();

    private string textForDisplay;

    // Start is called before the first frame update
    void Start()
    {
        textForDisplay = gameObject.GetComponent<Text>().text;

        textForDisplay = "The large donut has " + dessert4.calories + " and a taste factor of " + dessert4.taste;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            cookieFactory.CreateDessert(dessert4);


            textForDisplay = "The large donut has " + cookieFactory.CreateDessert(dessert4).calories + " and a taste factor of " + cookieFactory.CreateDessert(dessert4).taste;
        }

        gameObject.GetComponent<Text>().text = this.textForDisplay;
    }
}
