using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Cooper Denault
* BikeEngine
* Assignment 11
* Sets the fuel values 
*/

public class FuelPump : MonoBehaviour
{
    public BikeEngine engine;
    public IEnumerator burnFuel;

    private void Awake()
    {
        burnFuel = BurnFuel();
    }

    private IEnumerator BurnFuel()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            engine.fuelAmount -= engine.burnRate;

            if (engine.fuelAmount <= 0.0f)
            {
                engine.TurnOff();
                yield return 0;
            }
        }
    }
}