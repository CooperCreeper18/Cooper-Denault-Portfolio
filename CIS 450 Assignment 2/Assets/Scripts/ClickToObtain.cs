using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToObtain : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(rayOrigin, out hitInfo))
            {

                IUsingItem objectHit = hitInfo.collider.GetComponent<IUsingItem>();

                if (objectHit != null)
                {
                    objectHit.Use();
                }
            }
        }


    }
}
