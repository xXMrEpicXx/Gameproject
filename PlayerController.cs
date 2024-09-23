using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MovementSpeed = 5f;
    public float jumpHeight = 3f;
    public float rotationSpeed = 10f;
    public Transform Cam;
    public Transform orientation;
    public Transform player;
    public Transform playerObj;
    public Rigidbody rb;
    public GameObject Weapon;

    private Vector3 moveDirection;
    private Vector3 inputDir;
    private float horizontal;
    private float vertical;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        RotatePlayer();
        Movement();
        Jump(); // Call the jump method
    }

    void RotatePlayer()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        // Calculate direction relative to the camera
        Vector3 cameraForward = Cam.forward;
        cameraForward.y = 0; // Ignore y-axis to prevent tilting
        Vector3 cameraRight = Cam.right;
        cameraRight.y = 0; // Ignore y-axis to prevent tilting

        // Normalize the vectors to ensure consistent movement
        cameraForward.Normalize();
        cameraRight.Normalize();

        // Combine directions based on input
        inputDir = cameraForward * vertical + cameraRight * horizontal;

        if (inputDir != Vector3.zero)
        {
            playerObj.forward = Vector3.Slerp(playerObj.forward, inputDir.normalized, Time.deltaTime * rotationSpeed);
        }
    }

    void Movement()
    {
        // Move in the direction relative to the camera
        Vector3 targetVelocity = inputDir .normalized * MovementSpeed;
        rb.velocity = new Vector3(targetVelocity.x, rb.velocity.y, targetVelocity.z);
    }

    void Jump()
    {

    }
    void Skills() { }
    void Ult() { }
    void Dash() { }
    void ADS() { }
}
