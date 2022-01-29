using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    Transform player;
    void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        FollowWithTween();
    }
    void FollowWithTween()
    {
        transform.position += (player.position - transform.position) * 0.05f;
        transform.position = new Vector3(transform.position.x, transform.position.y, -10);
    }
}
