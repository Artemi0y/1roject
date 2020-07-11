using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public CharacterController controller;
    public float jumpHeight;
    public float gravity;
    public Transform groundCheck;
    public LayerMask groundMask;

    private Vector3 velocity;
    private float groundDistance;
    private bool isGrounded;

    void Awake()
    {

        groundDistance = 0.5f;
        jumpHeight = 4;
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        float xAxis = Input.GetAxis("Horizontal");
        float zAxis = Input.GetAxis("Vertical");

        Vector3 move = transform.forward * zAxis + transform.right * xAxis;
        controller.Move(move * speed * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -0.5f;
        }
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }

    }
}
