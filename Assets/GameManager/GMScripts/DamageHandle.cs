using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandle : MonoBehaviour
{
    // Ini Untuk menghandle damage. Sebaiknya taruk di GameManager biar dia yang handle
    public void DoDamage(int damage, Transform ditembak)
    {   
        
        int NewHealth = ditembak.GetComponent<EntityHealth>().health - damage;
        ditembak.GetComponent<EntityHealth>().SetHealth(NewHealth);
        print(damage + " to " + ditembak.name); 
    }
}
