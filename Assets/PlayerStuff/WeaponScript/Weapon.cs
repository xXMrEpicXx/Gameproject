using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera cam;
    public float AttackSpeed;
    public float CritChance;
    public float CritDamage;
    public static GameObject GameManager;
    void Start()
    {
        GameManager = GameObject.FindWithTag("GameManager");
        AttackSpeed = 0;
        CritChance = 0f;
        CritDamage = 0f;
    }

    // Update is called once per frame
    public virtual void Attack()
    {

    }

    void Skill()
    {

    }

    


    //universal weapon script klo inherit ae ini
}
