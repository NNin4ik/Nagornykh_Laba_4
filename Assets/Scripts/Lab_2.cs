using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab_2 : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 MoveVector;
    private Vector3 JumpVector;
    private bool IsGrounded;
    [SerializeField] float Speed = 2f;
    [SerializeField] float Jump;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        move();
        jump();
    }

    void move()
    {
        
        MoveVector.x = Input.GetAxis("Horizontal");
        MoveVector.z = Input.GetAxis("Vertical");
        rb.AddForce(MoveVector * Speed);
    }
    void jump()
    {
        if(Physics.Raycast(transform.position, Vector3.down, 1f))
        {
            IsGrounded = true;
        }
        else
        {
            IsGrounded = false;
        }

        if (IsGrounded)
            JumpVector.y = Input.GetAxis("Jump");
        else
            JumpVector.y = 0;
        rb.AddForce(JumpVector * Jump);
    }
}
