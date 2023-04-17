using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Cooper Denault
* CoolingSystem
* Assignment 11
* Sets the CoolingSystem and changes the temp values
*/

public class CoolingSystem : MonoBehaviour
{

    public BikeEngine engine;
    public IEnumerator coolEngine;
    private bool _isPaused;

    private void Awake()
    {
        coolEngine = CoolEngine();
    }

    public void PauseCooling()
    {
        _isPaused = !_isPaused;
    }

    public void ResetTemperature()
    {
        engine.currentTemp = 0.0f;
    }

    private IEnumerator CoolEngine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);

            if (!_isPaused)
            {
                if (engine.currentTemp > engine.minTemp)
                {
                    engine.currentTemp -= engine.tempRate;
                }
                else if (engine.currentTemp < engine.minTemp)
                {
                    engine.currentTemp += engine.tempRate;
                }
            }
            else
            {
                engine.currentTemp += engine.tempRate;
            }

            if (engine.currentTemp > engine.maxTemp)
            {
                engine.TurnOff();
            }
        }
    }
}
