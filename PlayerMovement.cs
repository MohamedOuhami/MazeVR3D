using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // This script is responsible of the movement of the player
    // When pressing "W". The player will move forward
    // When pressing "S". The player will move backwards
    // When pressing "D". The player will rotate on the Y axis to the right
    // When pressing "A:. The player will rotate on the Y axis to the left

    // Variables
    public float speed;

    private void Start()
    {

    }

    private void FixedUpdate()
    {
        // Moving forward
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * speed;
        }
        // Moving backward
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }
        // Rotating right
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0,speed,0);
        }
        // Rotating left
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -speed, 0);
        }

    }
}
