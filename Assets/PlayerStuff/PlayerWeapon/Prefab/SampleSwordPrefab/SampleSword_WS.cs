using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SampleSword_WS : Weapon
{
    // Start is called before the first frame update
    public int damage;
    public Collider Hitbox;
    public float HitBoxTime;
    void Start()
    {
        HitBoxTime = .6f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Attack()
    {

        Hitbox.enabled = true;
        HitBoxTime -= Time.deltaTime;
        
        if (HitBoxTime <= 0)
        {
            Hitbox.enabled = false;
            HitBoxTime = .6f;
        }

        
    }

    void OnCollisionEnter(Collider collider)
    {
        print("masuk");
    }

}
