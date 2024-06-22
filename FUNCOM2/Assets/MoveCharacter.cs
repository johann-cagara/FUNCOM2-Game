using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    // Start is called before the first frame update

    public float movementSpeed = 5.0f;
    //public float rotationSpeed = 5.0f;

    public Rigidbody2D rb;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {

        ProcessInputs();
        //rb.MovePosition(transform.position + movement * movementSpeed * Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            // Handle object interaction (e.g., picking up objects)
        }
    }

    void FixedUpdate()
    {
        Move();
    }

    void ProcessInputs()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        movement = new Vector2(horizontalInput, verticalInput).normalized;
    }

    void Move()
    {
        rb.velocity = new Vector2(movement.x * movementSpeed, movement.y * movementSpeed);
    }
}
