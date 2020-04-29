using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyai : MonoBehaviour
{
    [SerializeField] Transform target;
    NavMeshAgent navMeshAgent;
    [SerializeField] float rangedis = 3f;
    float distance;
    bool isprovoked = false;
    // Start is called before the first frame update


    void OnDrawGizmosSelected()
    {

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, rangedis);

    }


    void Start()
    {
        distance = Mathf.Infinity;
        navMeshAgent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        rangeofenemy();
       
    }

    void rangeofenemy()
    {
        distance = Vector3.Distance(transform.position, target.position);
        
        if(isprovoked)
        {
            chase();
        }
        else if(distance<=rangedis)
        {
            isprovoked = true;

        }

    
    }
    void chase()
    {
        if (distance <= navMeshAgent.stoppingDistance)
        {
            Debug.Log("its attacking");
        }

        else if (distance > navMeshAgent.stoppingDistance)

        {
            navMeshAgent.SetDestination(target.position);
           
        }
    }
}
