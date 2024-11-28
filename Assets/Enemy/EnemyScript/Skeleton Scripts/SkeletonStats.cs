using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonStats : MonoBehaviour
{
    
    public EntityHealth Health;


    // Start is called before the first frame update
    void Start()
    {
        Health = GetComponent<EntityHealth>();
        Health.SetHealth(10);
        Health.EnemyOrNot();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
