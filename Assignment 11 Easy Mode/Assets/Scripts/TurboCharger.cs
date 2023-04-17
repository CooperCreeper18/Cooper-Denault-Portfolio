using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Cooper Denault
* BikeEngine
* Assignment 11
* Sets the turbo charge variable and allows it too cool down
*/

public class TurboCharger : MonoBehaviour
{
    public BikeEngine engine;

    public bool _isTurboOn;
    private CoolingSystem _coolingSystem;

    public void ToggleTurbo(CoolingSystem coolingSystem)
    {
        _coolingSystem = coolingSystem;
        if (!_isTurboOn)
        {
            StartCoroutine(TurboCharge());
        }
    }

    private IEnumerator TurboCharge()
    {
        _isTurboOn = true;
        _coolingSystem.PauseCooling();

        yield return new WaitForSeconds(engine.turboDuration);

        _isTurboOn = false;
        _coolingSystem.PauseCooling();
    }

   
}
