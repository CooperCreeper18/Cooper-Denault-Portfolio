using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Cooper Denault
* Player
* Assignment 10
* Allows the player to fire when attached to the main camera
*/


public class Player : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;

    private void Update()
    {
        Fire();
    }


    private void Fire()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject bullet = PoolManager.Instance.RequestBullet();
            bullet.transform.position = Vector3.zero;
        }
    }
}
