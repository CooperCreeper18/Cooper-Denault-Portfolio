using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class smallcookietext : MonoBehaviour
{
    Dessert dessert1 = new SmallCookie();

    CookieFactory cookieFactory = new CookieFactory();

    private string textForDisplay;

    // Start is called before the first frame update
    void Start()
    {
        textForDisplay = gameObject.GetComponent<Text>().text;

        textForDisplay = "The small cookie has " + dessert1.calories + " and a taste factor of " + dessert1.taste;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            cookieFactory.CreateDessert(dessert1);


            textForDisplay = "The small cookie has " + cookieFactory.CreateDessert(dessert1).calories + " and a taste factor of " + cookieFactory.CreateDessert(dessert1).taste;
        }

        gameObject.GetComponent<Text>().text = this.textForDisplay;
    }
}
