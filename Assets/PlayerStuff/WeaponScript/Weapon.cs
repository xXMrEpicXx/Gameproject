using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int Damage;
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
        print("masuk base class");
    }

    void Skill()
    {

    }

    public void DamageSetter(int newDamage)
    {
        Damage = newDamage;
    }

    public int DamageGetter()
    {
        return Damage;
    }
    
    //universal weapon script klo inherit ae ini
}
