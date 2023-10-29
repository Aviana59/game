using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class AutoMoveLeft : MonoBehaviour
{
    public float speed = 25.0f;
    public Vector2 moveDirection = Vector2.left;
    private Rigidbody2D rb;
    public bool isMove = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isMove)
        {
            rb.velocity = moveDirection.normalized * speed;
        }
        else
        {
            rb.velocity = Vector2.zero; 
        }
    }

}
