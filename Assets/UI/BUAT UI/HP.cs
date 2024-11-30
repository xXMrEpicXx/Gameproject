using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public Slider healthslider;
    public float maxHealth = 100;
    public float health;
    private bool IsDead;
    public GameObject gamee;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (healthslider.value != health)
        {
            healthslider.value = health;
        }
        if (!Pause.IsPaused)
        {
            if (Input.GetKeyDown(KeyCode.Space))
               
                takedmg(10);
        }
        if(health <= 0 && !IsDead)
        {
            gamee.SetActive(true);
        }

    }
    void takedmg(float dmg)
    {
        health -= dmg;
    }
    public void Respawn()
    {
        gamee.SetActive(false);
        health = 100;
    }
}
