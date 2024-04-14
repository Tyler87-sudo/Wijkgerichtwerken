using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;  

    [SerializeField]
    private float rotationSpeed; 

    private Rigidbody2D rb;
    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        Move();  
        Animate(); 
    }

    private void Move()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (horizontalInput > 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (horizontalInput < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        Vector2 movementDirection = new Vector2(horizontalInput, verticalInput);
        float inputMagnitude = Mathf.Clamp01(movementDirection.magnitude);
        movementDirection.Normalize();

        transform.Translate(movementDirection * speed * inputMagnitude * Time.deltaTime, Space.World);
    }

    private void Animate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        animator.SetFloat("MovementX", horizontalInput);
        animator.SetFloat("MovementY", verticalInput);
    }
}
