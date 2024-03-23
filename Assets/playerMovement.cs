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

        void Update() {
            
            float horizontalInput = Input.GetAxisRaw("Horizontal");
            float verticalInput = Input.GetAxisRaw("Vertical");
            
            animator.SetInteger("MovementInput", Convert.ToInt32(horizontalInput));
            animator.SetInteger("VerticalUp", Convert.ToInt32(verticalInput) + 2);
            
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
        
    }
