using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoost : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public float boostedJumpForce;
    private bool isBoostActive = false;

    private float originalJumpForce;

    void Start()
    {
        // Get the original jump force 
        if (playerMovement != null)
        {
            originalJumpForce = 5f;
        }
        else
        {
            Debug.LogError("[JumpBoost] PlayerMovement reference is not assigned.");
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
            ApplyBoost();
        }
        else
        {
            ResetJumpForce();
        }
    }

    void ApplyBoost()
    {
        playerMovement.jumpForce = boostedJumpForce;
        Debug.Log($"[JumpBoost] Boost applied! Jump force set to: {playerMovement.jumpForce}");
    }

    void ResetJumpForce()
    {
        playerMovement.jumpForce = originalJumpForce;
        Debug.Log($"[JumpBoost] Boost deactivated. Restored jump force to: {originalJumpForce}");
    }
}
