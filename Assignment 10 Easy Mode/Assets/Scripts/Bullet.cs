using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Cooper Denault
* Bullet
* Assignment 10
* Script for the bullet prefab and sets its speed along with destroying after time
*/


public class Bullet : MonoBehaviour
{
    private float _speed = 15f;

    private void OnEnable()
    {
        Invoke("Hide", 1f);
    }

    private void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * _speed);
    }

    private void Hide()
    {
        this.gameObject.SetActive(false);
    }
}
