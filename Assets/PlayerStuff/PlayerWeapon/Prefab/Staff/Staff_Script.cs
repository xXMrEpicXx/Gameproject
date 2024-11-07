using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staff_Script : Weapon
{
    public GameObject Bullet;
    public Transform bulletSpawnLoc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Attack()
    {
        Instantiate(Bullet,bulletSpawnLoc);
    }
}
