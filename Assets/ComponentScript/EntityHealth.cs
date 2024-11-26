using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;


    //ini logika untuk Health may entity kayak apapun bisa ditempel ini (box,enemy,player,boss,apapun dah)
    public void SetHealth(int newHealth)
    {
        health = newHealth;

        if (health <= 0)
        {
            CheckNumEnemy EnemyChecker = GameObject.FindGameObjectWithTag("GameManager").GetComponent<CheckNumEnemy>();
            EnemyChecker.RemoveEnemy(1);
            Destroy(gameObject);
        }
    }

    public void EnemyOrNot()
    {
        if (gameObject.tag == "Enemy")
        {
            CheckNumEnemy EnemyChecker = GameObject.FindGameObjectWithTag("GameManager").GetComponent<CheckNumEnemy>();
            EnemyChecker.AddEnemy(1);
            
        }
    }
}
