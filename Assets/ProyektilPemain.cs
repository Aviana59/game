using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyektilPemain : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Tembok")) // Pastikan tag objek tembok sesuai
        {
            TembokScript tembok = collision.gameObject.GetComponent<TembokScript>();
            if (tembok != null)
            {
                tembok.TerkenaTembakan();
            }
        }
        
        // Hancurkan proyektil setelah tabrakan
        Destroy(gameObject);
    }
}