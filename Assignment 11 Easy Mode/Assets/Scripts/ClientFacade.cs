using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Cooper Denault
* BikeEngine
* Assignment 11
* Makes the bike engine and has methods for buttons
*/

public class ClientFacade : MonoBehaviour
{
    private BikeEngine _bikeEngine;

    private void Awake()
    {
        _bikeEngine = gameObject.AddComponent<BikeEngine>();
    }


    public void TurnEngineOn()
    {
        _bikeEngine.TurnOn();
    }

    public void TurnEngineOff()
    {
        _bikeEngine.TurnOff();
    }

    public void Turbo()
    {
        _bikeEngine.ToggleTurbo();
    }


}