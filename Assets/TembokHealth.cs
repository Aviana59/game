using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TembokHealth : MonoBehaviour
{
    public GameObject tembok;
    public int durabilityTembok = 5;
    private float kecepatanDemage = 0.5f;
    private float nextDemage = 0.0f;
    private bool isHancur = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy") && !isHancur)
        {
            isHancur = true;
        }
    }

    void Update()
    {
        if (isHancur)
        {
            HancurkanTembok();
        }
        if (durabilityTembok <= 0)
        {
            Destroy(tembok);
            isHancur = false;
        }
  
    }

    void HancurkanTembok()
    {
        if (Time.time - nextDemage >= kecepatanDemage)
        {
            durabilityTembok--;
            nextDemage = Time.time;
        }
  
    }
}
