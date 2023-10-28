using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class AutoMoveLeft : MonoBehaviour
{
    public float speed = 25.0f; // Kecepatan karakter

    void Update()
    {
        // Gerakkan karakter ke kiri
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

	void Start()
	{
    // Ganti posisi awal karakter
    transform.position = new Vector3(1500, 149, 0); // Ganti koordinat sesuai kebutuhan
	}

}