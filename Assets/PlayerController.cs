using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public float attackSpeed = 0.5f; // Waktu cooldown tembakan
    public float bulletSpeed = 10f; // Kecepatan peluru
    public GameObject bulletPrefab; // Prefab peluru
    public Transform shootPos; // Transformasi lokasi tembakan

    private float coolDown = 0f;

    void Update()
    {
        if (Time.time >= coolDown && Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
    }

    void Fire()
    {
        // Membuat instans peluru pada posisi shootPos
        GameObject bullet = Instantiate(bulletPrefab, shootPos.position, shootPos.rotation);
        
        // Mendapatkan komponen Rigidbody2D peluru
        Rigidbody2D bulletRb = bullet.GetComponent<Rigidbody2D>();

        // Memberikan dorongan pada peluru dengan arah ke depan dan kecepatan bulletSpeed
        bulletRb.velocity = shootPos.up * bulletSpeed;

        // Mengatur waktu cooldown
        coolDown = Time.time + attackSpeed;
    }
}
