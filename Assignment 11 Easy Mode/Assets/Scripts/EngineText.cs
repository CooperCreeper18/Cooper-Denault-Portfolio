using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
* Cooper Denault
* BikeEngine
* Assignment 11
* Text for the values on screen
*/

public class EngineText : MonoBehaviour
{
    public GameObject engine;
    private BikeEngine script;

    public GameObject turbo;
    private TurboCharger script2;

    //public TurboCharger turbo;
    private string engineText;


    // Start is called before the first frame update
    void Start()
    {
        engineText = gameObject.GetComponent<Text>().text;
        script = engine.GetComponent<BikeEngine>();
        script2 = turbo.GetComponent<TurboCharger>();
    }

    // Update is called once per frame
    void Update()
    {
        engineText = "Engine Running: " + script._isEngineOn + "\n\n";
        engineText += "Temp: " + script.currentTemp + "\n\n";
        engineText += "Fuel: " + script.fuelAmount + "\n\n";
        engineText += "Turbo Activated: " + script2._isTurboOn;


        gameObject.GetComponent<Text>().text = engineText;
    }
}
