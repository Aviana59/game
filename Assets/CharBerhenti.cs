using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharBerhenti : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            AutoMoveLeft monster = other.gameObject.GetComponent<AutoMoveLeft>();
            monster.isMove = false;

            // Cari child GameObject dengan nama "ShootPeluru" dalam objek yang bertabrakan
            Transform peluruTransform = other.gameObject.transform.Find("ShootPeluru");

            if (peluruTransform != null)
            {
                // Dapatkan GameObject "ShootPeluru" dari transform
                GameObject peluru = peluruTransform.gameObject;

                // Dapatkan skrip "TembakPeluru" dari GameObject "ShootPeluru"
                TembakPeluru tembak = peluru.GetComponent<TembakPeluru>();

                if (tembak != null)
                {
                    tembak.isFire = true;
                }
            }
            else
            {
                Debug.Log("Child dengan nama 'ShootPeluru' tidak ditemukan.");
            }
        }
    }
}
