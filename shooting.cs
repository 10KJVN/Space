using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Transform BulletSpawnPoint;
    public GameObject Bullet;
    public float BulletSpeed = 50;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var bullet = Instantiate(Bullet, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = BulletSpawnPoint.forward * BulletSpeed;
        }
    }
}


