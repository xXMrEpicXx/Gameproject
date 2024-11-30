using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBuff : BlessingRoot
{
        int BlessingID = 2;
    public PlayerMovement playerMovement;
    public float buffedSpeed = 10f;  // Set speed
    private bool isBuffActive = false;

    private float originalSpeed;

    void Start()
    {
        // Get the original speed
        if (playerMovement != null)
        {
            originalSpeed = playerMovement.moveSpeed;
        }
        else
        {
            Debug.LogError("PlayerMovement reference is not assigned.");
        }
    }

    void Update()
    {
        // Toggle speed buff
        if (Input.GetKeyDown(KeyCode.B))
        {
            print("babi");
            ToggleBuff();
        }
    }

    void ToggleBuff()
    {
        if (playerMovement == null) return;

        // Toggle the buff state
        isBuffActive = !isBuffActive;

        if (isBuffActive)
        {
            playerMovement.moveSpeed = buffedSpeed;
            Debug.Log("Speed buff activated! Movement speed increased.");
        }
        else
        {
            playerMovement.moveSpeed = originalSpeed;
            Debug.Log("Speed buff deactivated. Movement speed returned to normal.");
        }
    }
}
