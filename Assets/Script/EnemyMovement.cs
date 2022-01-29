using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    GameObject player;
    Rigidbody2D rb;
    SpriteMask sprMask;
    [SerializeField]
    float speed = 10;
    [SerializeField]
    float distanceToPlayer = 20;
    float x;
    float y;
    bool isSeen = false;
    void Start()
    {
        player = GameObject.Find("Player");
        rb = GetComponent<Rigidbody2D>();
        sprMask = GameObject.Find("SpriteMask").GetComponent<SpriteMask>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        x = Mathf.Abs(player.transform.position.x - transform.position.x);
        y = Mathf.Abs(player.transform.position.y - transform.position.y);
        if (x+y < distanceToPlayer && !isSeen){
            Invoke(nameof(MoveTowardsPlayer),0);
        }
        else if(isSeen)
        {
            rb.velocity = new Vector2(0, 0);
        }
        else
        {
            rb.velocity = new Vector2(0, 0);
        }
    }
    void MoveTowardsPlayer()
    {
        rb.velocity = (player.transform.position - transform.position).normalized * speed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Flashlight"))
        {
            isSeen = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Flashlight"))
        {
            isSeen = false;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Flashlight"))
        {
            isSeen = true;
        }
    }
}
