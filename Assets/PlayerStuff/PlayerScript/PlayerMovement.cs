using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f; // Speed of the player movement
    public float lookSpeed = 2f;  // Speed of the camera look
    public Transform playerCamera; // Reference to the camera transform
    public float sensitivity = 2f; // Mouse sensitivity





    private float verticalRotation = 0f; // Vertical rotation of the camera
    public float jumpForce;
    public LayerMask groundLayer; // Assign ground layer in inspector
    private Rigidbody rb;
    public bool isGrounded;
    private float coyoteTime = 0.3f; // Duration of coyote time
    private float coyoteTimer = 0f;



    public int MovementSpeed;
    public int Armor;
    public Weapon WScript;
    public ActiveAbility Ability;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        MovementSpeed = 5;
        Armor = 5;
        rb = GetComponent<Rigidbody>();
        WScript = GetComponentInChildren<Weapon>();
        jumpForce = 5;

    }

    // Update is called once per frame
    void Update()
    {
        MovementLogic();
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Dash();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Ult();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Ability.ActiveSkill(playerCamera.transform);
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            WScript.Attack();
        }
        if (Input.GetButtonDown("Jump"))
        {
            print("lompat");
            jump();
        }



    }

    void MovementLogic()
    {

        if (isGrounded)
        {
            coyoteTimer = coyoteTime;
        }
        else
        {
            // Reduce coyote timer while in the air
            coyoteTimer -= Time.deltaTime;
        }

        // Get input for movement
        float moveX = Input.GetAxis("Horizontal") * moveSpeed;
        float moveZ = Input.GetAxis("Vertical") * moveSpeed;

        // Create movement vector based on input
        Vector3 move = transform.right * moveX + transform.forward * moveZ;

        // Set the velocity of the Rigidbody
        rb.velocity = new Vector3(move.x, rb.velocity.y, move.z); // Keep the vertical velocity unchanged

        // Mouse look
        float mouseX = Input.GetAxis("Mouse X") * lookSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * lookSpeed;

        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f);

        playerCamera.localRotation = Quaternion.Euler(verticalRotation +30, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);


    }


    void Dash()
    {
       
    }


    void Ult()
    {
        
    }


    void jump()
    {
        isGrounded = Physics.Raycast(transform.position, -transform.up, 1.15f);
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            if (isGrounded || coyoteTimer > 0)
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }

        }
    }
}
