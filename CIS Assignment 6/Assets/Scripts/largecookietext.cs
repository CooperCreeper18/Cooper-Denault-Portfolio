using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class largecookietext : MonoBehaviour
{
    Dessert dessert3 = new LargeCookie();

    CookieFactory cookieFactory = new CookieFactory();

    private string textForDisplay;

    // Start is called before the first frame update
    void Start()
    {
        textForDisplay = gameObject.GetComponent<Text>().text;

        textForDisplay = "The large cookie has " + dessert3.calories + " and a taste factor of " + dessert3.taste;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            cookieFactory.CreateDessert(dessert3);


            textForDisplay = "The large cookie has " + cookieFactory.CreateDessert(dessert3).calories + " and a taste factor of " + cookieFactory.CreateDessert(dessert3).taste;
        }

        gameObject.GetComponent<Text>().text = this.textForDisplay;
    }
}
