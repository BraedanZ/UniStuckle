using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unicycle : MonoBehaviour
{
    Unicycle unicycle;
    Player playerScript;
    public float speed;

    Rigidbody2D rb;

    public Vector2 playerPosition;
    public Vector2 unicyclePosition;

    public float lean;
    public float leanMultiplier;

    Vector2 pedalPower;

    float temp;


    // Start is called before the first frame update
    void Start()
    {
        unicycle = this;
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        unicyclePosition = rb.transform.position;

        // get arrow key input (up down)
        float input = Input.GetAxisRaw("Vertical");
        
        // move the wheel
        lean = calculateLean();
        print(lean);

        // if(input > 0) {
        //     pedalPower = new Vector2(1, 0) * input * speed * lean * leanMultiplier;
        //     rb.AddForce(pedalPower);
        // } else if(input < 0) {
        //     pedalPower = new Vector2(1, 0) * input * speed * -(lean - 4) * leanMultiplier;
        //     rb.AddForce(pedalPower);
        // }

        if(input > 0) {
            temp = -(input * speed * lean * leanMultiplier);
            rb.AddTorque(temp, ForceMode2D.Force);
        } else if(input < 0) {
            temp = -(input * speed * -(lean - 4) * leanMultiplier);
            rb.AddTorque(temp, ForceMode2D.Force);
        }
    }

    private float calculateLean() {
        playerPosition = playerScript.playerPosition;
        return playerPosition.x - unicyclePosition.x + 2;
    }
}
