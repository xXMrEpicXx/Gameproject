using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class DamageUp : BlessingRoot
{
    public GameObject Player;
    bool isThisPlayer= false;

    public void Update()
    {
        if(this.tag == "Player")
        {
            isThisPlayer = true;
        }
    }
    void GrantDamage(bool isThisPlayer)
    {
        if(!isThisPlayer)
        {
            Weapon WeaponScript = Player.GetComponentInChildren<Weapon>();
            int WDamage = WeaponScript.DamageGetter();
            WeaponScript.DamageSetter(WDamage+5);


        }
    }
}
