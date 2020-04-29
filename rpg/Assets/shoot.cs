using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    [SerializeField] Camera fpscamera;
    [SerializeField] float range = 100f;
    [SerializeField] float decrease = 30f;
    [SerializeField] ParticleSystem gunfire;
    [SerializeField] GameObject hiting;

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            gunfire.Play();
            shooting();
        }
    }

    void shooting()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpscamera.transform.position, fpscamera.transform.forward, out hit, range))
        {
            GameObject spark= Instantiate(hiting,hit.point,Quaternion.LookRotation(hit.normal));
            Destroy(spark,0.1f);

            enemyhealth health = hit.transform.GetComponent<enemyhealth>();
            if(hit.transform.name=="enemy")
            {
               
                health.enemydam(decrease);
            }
        }

    }
}
