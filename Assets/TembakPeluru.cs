using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TembakPeluru : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefabPeluru;
    public bool isFire = false;
    public float kecepatanTembak = 1.0f;
    private float nextTembak = 0.0f;

    void Start() {
        
    }
    void Update()
    {
        if (isFire)
        {
            GenerateFire();
        }
    }


    public void GenerateFire()
    {
        if (Time.time - nextTembak >= kecepatanTembak)
        {
            Transform spawnPoint = gameObject.transform;
            GameObject peluru = Instantiate(prefabPeluru, spawnPoint);
            nextTembak = Time.time;
        }
    }




}
