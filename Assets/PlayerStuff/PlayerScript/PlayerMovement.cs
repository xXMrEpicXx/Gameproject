using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    public bool Attackstate;

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
    Vector3 move;



    public int MovementSpeed;
    public int Armor;
    public Weapon WScript;
    public ActiveAbility Ability;



    public Animator animator;









    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Armor = 5;
        rb = GetComponent<Rigidbody>();
        WScript = GetComponentInChildren<Weapon>();
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        MovementLogic();
        HandleMovement();
        UpdateAnimator();
        HandleMouseLook();

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
            animator.SetBool("Attacking", true);
            WScript.Attack();
            BoxCollider box = GetComponentInChildren<BoxCollider>();
            box.enabled=true;
            StartCoroutine(Attacking(1));

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

    }

    void HandleMovement()
    {
        // Get input for movement
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        // Create movement vector relative to player's orientation
        Vector3 move = (transform.right * moveX + transform.forward * moveZ).normalized;

        // Apply movement to Rigidbody, preserving Y velocity
        Vector3 velocity = move * moveSpeed;
        velocity.y = rb.velocity.y; // Preserve vertical velocity (e.g., for gravity or jumps)
        rb.velocity = velocity;
    }

    void HandleMouseLook()
    {
        // Get mouse input
        float mouseX = Input.GetAxis("Mouse X") * lookSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * lookSpeed;

        // Adjust vertical rotation and clamp it
        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f);

        // Rotate camera vertically and player horizontally
        playerCamera.localRotation = Quaternion.Euler(verticalRotation + 30, 0f, 0f); // Adjusted for camera tilt
        transform.Rotate(Vector3.up * mouseX);
    }

    void UpdateAnimator()
    {
        // Update the "velocity" parameter based on horizontal movement speed
        Vector3 horizontalVelocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
        animator.SetFloat("velocity", horizontalVelocity.magnitude);
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


    void WalkingAnim()
    {
        animator.SetBool("isWalking", true);
    }



    IEnumerator Attacking(float attackDuration)
    {
        BoxCollider box = GetComponentInChildren<BoxCollider>();
        // Start the attacking animation
        Animator animator = GetComponent<Animator>();
        animator.SetBool("Attacking", true);

        // Wait for the duration of the attack
        yield return new WaitForSeconds(attackDuration);

        // End the attacking animation
        animator.SetBool("Attacking", false);
        box.enabled = false;
        
    }
}
