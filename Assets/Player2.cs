using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class GerakOtomatis : MonoBehaviour
{
    public float speed = 50.0f; // Kecepatan karakter

    void Terbaru()
    {
        // Gerakkan karakter ke kiri
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

	void Mulai()
	{
    // Ganti posisi awal karakter
    transform.position = new Vector3(1500, 190, 0); // Ganti koordinat sesuai kebutuhan
	}

}