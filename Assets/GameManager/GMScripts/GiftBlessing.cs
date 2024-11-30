using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftBlessing : MonoBehaviour
{
    public GameObject Player;
    public BlessingRoot [] ListOfBlessings;
    public BlessingRoot [] PickableBlessing;

    public void Start()
    {
        Player = GameObject.Find("Player");
        AddBlessingsToArray();
    }
    void RandomizeBlessing()
    {
        
    }

    void AssignNumb()
    {

    }

    void AddBlessingsToArray()
    {
   
        
        
            ListOfBlessings = FindObjectsOfType<BlessingRoot>();

        
        
    }



}
