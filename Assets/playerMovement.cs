using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TreeEditor;
using Unity.Mathematics;
using UnityEngine;

    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField]
        private float speed;

        [SerializeField]
        private float rotationSpeed;

        protected Rigidbody2D rb;
        protected Collider2D col;
        private Animator animator;

        void Start()
        {
            rb = gameObject.GetComponent<Rigidbody2D>();
            animator = gameObject.GetComponent<Animator>();
        }

        void Update()
        {

            Move();
            Animate();
            
            float horizontalInput = Input.GetAxisRaw("Horizontal");
            float verticalInput = Input.GetAxisRaw("Vertical");
            
            if (horizontalInput > 0)
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
            } else if (horizontalInput < 0)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }

            Vector2 movementDirection = new Vector2(horizontalInput, verticalInput);
            float inputMagnitude = Mathf.Clamp01(movementDirection.magnitude);
            movementDirection.Normalize();
            

            transform.Translate(movementDirection * speed * inputMagnitude * Time.deltaTime, Space.World);
            
        }

        private void Move()
        {
            
        }

        private void Animate()
        {
            float horizontalInput = Input.GetAxisRaw("Horizontal");
            float verticalInput = Input.GetAxisRaw("Vertical");
            animator.SetFloat("MovementX", horizontalInput);
            animator.SetFloat("MovementY", verticalInput);
        }
        
    }
