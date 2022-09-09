using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Player player;

    public float speed;

    Rigidbody2D rb;

    public Vector2 playerPosition;


    // Start is called before the first frame update
    void Start()
    {
        player = this;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        playerPosition = rb.transform.position;

        // get arrow key input (left right)
        float input = Input.GetAxisRaw("Horizontal");
        
        // move the player
        rb.AddForce(transform.right * input * speed);
    }
}
