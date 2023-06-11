// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Weapon : MonoBehaviour
// {
//     public Transform firePoint;
//     public GameObject bulletPrefab;

//     // Update is called once per frame
//     void Update()
//     {
//      if (Input.GetButtonDown("Fire1")){
//         Shoot();
//      }   
//     }
//     void Shoot ()
//     {
//         // haha shooting go brr
//         Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
//     }
// }
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Weapon : MonoBehaviour
// {
//     public Transform firePoint;
//     public GameObject bulletPrefab;
//     public float shootDelay = 0.05f; // Time delay between shots

//     private float shootTimer = 0f;
//     private bool isShooting = false;

//     void Update()
//     {
//         if (Input.GetButtonDown("Fire1"))
//         {
//             isShooting = true;
//         }
//         if (Input.GetButtonUp("Fire1"))
//         {
//             isShooting = false;
//         }

//         if (isShooting)
//         {
//             shootTimer -= Time.deltaTime;
//             if (shootTimer <= 0f)
//             {
//                 Shoot();
//                 shootTimer = shootDelay;
//             }
//         }
//     }

//     void Shoot()
//     {
//         Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
//     }
// }
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float shootDelay = 0.001f; // Time delay between shots

    private float shootTimer = 0f;
    private bool isShooting = false;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            isShooting = true;
            Shoot();
            shootTimer = shootDelay;
        }
        if (Input.GetButtonUp("Fire1"))
        {
            isShooting = false;
        }

        if (isShooting)
        {
            shootTimer -= Time.deltaTime;
            if (shootTimer <= 0f)
            {
                Shoot();
                shootTimer = shootDelay;
            }
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
