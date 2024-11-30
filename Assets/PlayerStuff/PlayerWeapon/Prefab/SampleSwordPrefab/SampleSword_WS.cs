using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SampleSword_WS : Weapon
{
    // Start is called before the first frame update

    void Start()
    {
        DamageSetter(5);
        GameManager = GameObject.FindWithTag("GameManager");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Attack()
    {
        print("Masuk Attack Script Senjata (Melee)");
        BoxCollider col = GetComponent<BoxCollider>();
        col.enabled = true;
    }

    void OnTriggerEnter(Collider other)
    {
        print("Collide");
        if (!other.CompareTag("Player"))
        {
            DamageHandle damageHandler = GameManager.GetComponent<DamageHandle>();
            damageHandler.DoDamage(base.DamageGetter(),other.transform);

        }
        
    }



}
