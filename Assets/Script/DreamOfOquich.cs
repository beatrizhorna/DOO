using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamOfOquich: MonoBehaviour
{
    public float Speed;
    public float JumpForce;

    private Rigidbody2D rigidbody2D;
    private float Horizontal;
    
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            Jump();
        }
    }

    private void Jump()
    {
        rigidbody2D.AddForce(Vector2.up * JumpForce);
}
}
