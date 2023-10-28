using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public void Die()
    {
        // Lakukan apa yang diperlukan saat karakter mati di sini.
        // Misalnya, putar animasi kematian, tampilkan pesan game over, atau kembali ke menu awal.
        // Anda juga dapat menonaktifkan GameObject karakter jika diperlukan.
        gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
    if (other.CompareTag("Tembok"))
    {
        // Panggil metode Die() dari skrip PlayerDeath
        GetComponent<PlayerDeath>().Die();
    }
    }

}
