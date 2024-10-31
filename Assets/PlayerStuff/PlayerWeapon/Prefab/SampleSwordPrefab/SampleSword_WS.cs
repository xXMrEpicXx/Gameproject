using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SampleSword_WS : Weapon
{
    // Start is called before the first frame update
    public int Damage;
    public float HitBoxTime;
    void Start()
    {
        GameManager = GameObject.FindWithTag("GameManager");
        HitBoxTime = .6f; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Attack()
    {

    }

    void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (!other.transform.CompareTag("Player"))
        {
            DamageHandle damageHandler = GameManager.GetComponent<DamageHandle>();
            damageHandler.DoDamage(Damage,other.transform);

        }
        
    }



}
