using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckNumEnemy : MonoBehaviour
{

    public int NumOfEnemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RoomClear()
    {
        if (NumOfEnemy <= 0)
        {
            return;
        }
    }

    public void AddEnemy(int num)
    {
        NumOfEnemy = NumOfEnemy + num;
    }

    public void RemoveEnemy(int num)
    {
        NumOfEnemy = NumOfEnemy - num;
    }
}
