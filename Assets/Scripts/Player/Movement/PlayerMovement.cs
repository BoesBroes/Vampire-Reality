using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("movement")]

    public float moveSpeed;

    public float groundDrag;

    [Header("ground check")]
    public float playerHeight;
    public LayerMask ground;
    private bool grounded;

    public Transform orientation;

    float horizontalInput;
    float verticalInput;

    Vector3 moveDirection;

    Rigidbody rigidBody;


    public bool paused;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        PlayerInput();
        SpeedControl();

        //grounded check
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.6f);

        if (grounded)
        {
            rigidBody.drag = groundDrag;
        }
        else
        {
            rigidBody.drag = 0;
        }
    }

    private void FixedUpdate()
    {
        if(!paused)
        {
            MovePlayer();
        }
    }

    private void PlayerInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void MovePlayer()
    {
        //calculate movement
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

        rigidBody.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
    }

    private void SpeedControl()
    {
        Vector3 flatSpeed = new Vector3(rigidBody.velocity.x, 0, rigidBody.velocity.z);

        //limit velocity
        if (flatSpeed.magnitude > moveSpeed)
        {
            Vector3 limitedSpeed = flatSpeed.normalized * moveSpeed;
            rigidBody.velocity = new Vector3(limitedSpeed.x, rigidBody.velocity.y, limitedSpeed.z);
        }

    }

}
