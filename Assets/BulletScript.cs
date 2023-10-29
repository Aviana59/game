using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float kecepatanTembak = 5.0f;
    public string targetTag = "Target"; // Ganti dengan tag yang sesuai

    void Update()
    {
        MoveTowardsTarget();
    }

    void MoveTowardsTarget()
    {
        GameObject[] targets = GameObject.FindGameObjectsWithTag(targetTag);

        if (targets.Length > 0)
        {
            Transform targetTransform = targets[0].transform; // Misalnya, ambil target pertama

            // Hitung arah dari peluru ke objek target
            Vector2 direction = (targetTransform.position - transform.position).normalized;

            // Atur kecepatan peluru dengan arah yang dihitung
            GetComponent<Rigidbody2D>().velocity = direction * kecepatanTembak;
        }
    }

	void OnTriggerEnter2D(Collider2D other) {
		if(other.CompareTag(targetTag)){
			Destroy(gameObject);
		}
	}
}
