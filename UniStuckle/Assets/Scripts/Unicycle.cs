using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unicycle : MonoBehaviour
{

    public float speed;

    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get arrow key input (left right)
        float input = Input.GetAxisRaw("Vertical");
        
        // move the wheel
        rb.velocity = new Vector2(input * speed, rb.velocity.y);
    }
}
