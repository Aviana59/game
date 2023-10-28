using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharBerhenti : MonoBehaviour
{
    // Start is called before the first frame update

    void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Enemy")){
            AutoMoveLeft Monster = other.gameObject.GetComponent<AutoMoveLeft>();
            Monster.isMove = false;
        }
    }
}
