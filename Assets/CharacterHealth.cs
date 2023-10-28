using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Menjalankan tindakan kematian karakter di sini
        // Misalnya, mematikan animasi, menonaktifkan komponen, atau memunculkan efek kematian
        Destroy(gameObject); // Opsional, untuk menghapus karakter dari adegan
    }
}
