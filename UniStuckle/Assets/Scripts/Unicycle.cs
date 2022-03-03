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
    public float antiLeanMultiplier;

    Vector2 pedalPower;

    // public WheelJoint2D wheel;

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
        // JointMotor2D motor;
        if(lean >= 0 && input > 0) {
            pedalPower = new Vector2(1, 0) * input * speed * lean * leanMultiplier;
            rb.AddForce(pedalPower);
            // motor = new JointMotor2D { motorSpeed = input * speed * lean * leanMultiplier, maxMotorTorque = 10000 };
        } 
        
        else if (lean >= 0 && input < 0) {
            pedalPower = new Vector2(1, 0) * input * speed * lean * antiLeanMultiplier;
            rb.AddForce(pedalPower);
            // motor = new JointMotor2D { motorSpeed = input * speed * lean * antiLeanMultiplier, maxMotorTorque = 10000 };
        } 
        
        else if (lean < 0 && input > 0) {
            pedalPower = new Vector2(1, 0) * input * speed * -lean * antiLeanMultiplier;
            rb.AddForce(pedalPower);
            // motor = new JointMotor2D { motorSpeed = input * speed * -lean * antiLeanMultiplier, maxMotorTorque = 10000 };
        } 
        
        else if (lean < 0 && input < 0) {
            pedalPower = new Vector2(1, 0) * input * speed * -lean * leanMultiplier;
            rb.AddForce(pedalPower);
            // motor = new JointMotor2D { motorSpeed = input * speed * -lean * leanMultiplier, maxMotorTorque = 10000 };
        } 
        // else {
            // motor = new JointMotor2D { motorSpeed = 0, maxMotorTorque = 10000 };
        // }
        // wheel.motor = motor;
        
    }

    private float calculateLean() {
        playerPosition = playerScript.playerPosition;
        return playerPosition.x - unicyclePosition.x;
    }
}
