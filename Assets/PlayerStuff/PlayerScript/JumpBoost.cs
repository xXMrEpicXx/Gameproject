using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoost : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public float boostedJumpForce = 15f;  // Boosted jump force value
    private bool isBoostActive = false;

    private float originalJumpForce;

    void Start()
    {
        // Get the original jump force 
        if (playerMovement != null)
        {
            originalJumpForce = playerMovement.jumpForce;
        }
        else
        {
            Debug.LogError("PlayerMovement reference is not assigned.");
        }
    }

    void Update()
    {
        // Toggle jump boost
        if (Input.GetKeyDown(KeyCode.J))
        {
            ToggleBoost();
        }
    }

    void ToggleBoost()
    {
        if (playerMovement == null) return;

        // Toggle the boost state
        isBoostActive = !isBoostActive;

        if (isBoostActive)
        {
            playerMovement.jumpForce = boostedJumpForce;
            Debug.Log("Jump boost activated! Increased jump force.");
        }
        else
        {
            playerMovement.jumpForce = originalJumpForce;
            Debug.Log("Jump boost deactivated. Jump force returned to normal.");
        }
    }
}
