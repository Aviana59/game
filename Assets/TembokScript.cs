using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TembokScript : MonoBehaviour
{
    public int kesehatanTembok = 3;

    public void TerkenaTembakan()
    {
        kesehatanTembok--;
        
        if (kesehatanTembok <= 0)
        {
            Mati();
        }
    }

    private void Mati()
    {
        Destroy(gameObject);
    }
}

