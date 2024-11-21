using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class HPScript : MonoBehaviour
{
    public Image currentHealthBar;
    public TMP_Text ratioText;
    public Slider slider;

    private float hitpoint = 150;
    private float maxHitpoint = 150;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            TakeDamage(1);
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            HealHealth(1);
        }
        UpdateHealthbar();
    }

     private void UpdateHealthbar()
    {
        float ratio = hitpoint / maxHitpoint;
        //currentHealthBar.rectTransform.localScale = new Vector3(ratio, 1, 1);
        ratioText.text = (ratio * 100).ToString() + '%';
        slider.value = ratio;
    }  
    private void TakeDamage(float Damage)
    {
        hitpoint -= Damage;
        if (hitpoint < 0)
        {
            //destroy
            hitpoint = 0;
        }
    }
    private void HealHealth(float Heal)
    {
        hitpoint += Heal;
        if (hitpoint > maxHitpoint)
        {
            hitpoint = maxHitpoint;
        }
    }


        

}
