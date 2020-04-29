using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhealth : MonoBehaviour
{
    [SerializeField] float health = 100f;
    void Start()
    {
        
    }
    public void enemydam(float decrease)
    {
       if(health>=30)
        {
            health = health - decrease;
        }

       else
        {
            Destroy(gameObject);
        }
    }
    
    void Update()
    {
        
    }
}
