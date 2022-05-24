using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab_1 : MonoBehaviour
{
    [SerializeField] private float MoveSpeed;
    [SerializeField] private float JumpDistance;
    private Vector3 NextPosition;
    private Vector3 Position;
    private bool isGrounded;
    private float Distance = 0.5f;

    void Start()
    {
        Position = transform.position;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime);
        }

        Position = transform.position;
        NextPosition = new Vector3(0, -0.1f, 0);

        if (Physics.Raycast(transform.position, Vector3.down, 0.6f))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
        Distance += (-9.81f) * Time.deltaTime;

        if (isGrounded && Distance < 0.5f)
        {
            Distance = 0.5f;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Distance = JumpDistance;
        }
        transform.Translate(new Vector3(0, Distance, 0) * Time.deltaTime);

    }
}
