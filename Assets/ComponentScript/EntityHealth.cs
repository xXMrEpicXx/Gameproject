using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityHealth : MonoBehaviour
{
    // Start is called before the first frame update

    public int maxHealth;
    public int health;

    public void Start()
    {

    }

    //ini logika untuk Health may entity kayak apapun bisa ditempel ini (box,enemy,player,boss,apapun dah)
    public void SetHealth(int newHealth)
    {
        health = newHealth;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
