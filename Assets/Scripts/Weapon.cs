using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        //När Fire1 används Spawn bullet prefab
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    //Spawns the prefab for bullet
    void Shoot ()
        //shoting logic
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
