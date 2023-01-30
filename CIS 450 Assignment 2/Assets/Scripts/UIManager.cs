using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * (Cooper Denault)
 * (UI Manager)
 * (Assignment 2)
 * (Allows the different feedbacks to appear)
 */



public class UIManager : MonoBehaviour
{
    public GameObject healthText;
    public GameObject armourText;
    public GameObject keyText;
    public GameObject specialText;

    public GameObject healthItem;
    public GameObject armourItem;
    public GameObject keyItem;
    public GameObject specialItem;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(healthItem == null && Input.GetKeyDown(KeyCode.Alpha1))
        {
            healthText.SetActive(true);
        }

        if (armourItem == null && Input.GetKeyDown(KeyCode.Alpha2))
        {
            armourText.SetActive(true);
        }

        
        if (keyItem == null && Input.GetKeyDown(KeyCode.Alpha3))
        {
            keyText.SetActive(true);
        }
        

        if (specialItem == null && Input.GetKeyDown(KeyCode.Alpha4))
        {
            specialText.SetActive(true);
        }
    }
}
