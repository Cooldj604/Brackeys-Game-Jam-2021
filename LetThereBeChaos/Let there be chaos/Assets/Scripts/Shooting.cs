using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;
    public float shootingRate = 100f;
    private float shootCooldown = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= shootCooldown)
        {
            shootCooldown = Time.time + 1f / shootingRate;
            Shoot();
        }
    }


    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firepoint.up * -bulletForce, ForceMode2D.Impulse);

    }

}
