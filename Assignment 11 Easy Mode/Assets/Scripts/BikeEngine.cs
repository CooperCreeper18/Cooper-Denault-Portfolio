using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
* Cooper Denault
* BikeEngine
* Assignment 11
* Assigns the Bike Engine and makes the starter variables along with the abilites to turn on and off
*/

public class BikeEngine : MonoBehaviour
{
    public float burnRate = 1f;
    public float fuelAmount = 100f;
    public float tempRate = 5f;
    public float minTemp = 50f;
    public float maxTemp = 65f;
    public float currentTemp;
    public float turboDuration = 2f;

    private FuelPump _fuelPump;
    private TurboCharger _turboCharger;
    private CoolingSystem _coolingSystem;
    public bool _isEngineOn;



    private void Awake()
    {
        _fuelPump = gameObject.AddComponent<FuelPump>();
        _turboCharger = gameObject.AddComponent<TurboCharger>();
        _coolingSystem = gameObject.AddComponent<CoolingSystem>();
    }

    private void Start()
    {
        _fuelPump.engine = this;
        _turboCharger.engine = this;
        _coolingSystem.engine = this;
    }

    public void TurnOn()
    {
        _isEngineOn = true;
        StartCoroutine(_fuelPump.burnFuel);
        StartCoroutine(_coolingSystem.coolEngine);
    }

    public void TurnOff()
    {
        _isEngineOn = false;
        _coolingSystem.ResetTemperature();
        StopCoroutine(_fuelPump.burnFuel);
        StopCoroutine(_coolingSystem.coolEngine);
    }

    public void ToggleTurbo()
    {
        if (_isEngineOn)
        {
            _turboCharger.ToggleTurbo(_coolingSystem);
        }
    }


}
