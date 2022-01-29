using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    Vector2 movement;
    SpriteRenderer sprRend;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprRend = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        
    }
    void FixedUpdate()
    {
        Move();
    }
    void Move()
    {
        movement = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
        movement.Normalize();
        rb.velocity = movement * speed * Time.deltaTime;
    }
    void FlipSpriteOnMousePosition()
    {
        var mousePosX = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if(transform.position.x > mousePosX.x)
        {
            sprRend.flipX = true;
        }
        else
        {
            sprRend.flipX = false;
        }
    }
}
