using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
    
{
    public Transform target;
    public GameObject projectile;
 
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.LookAt(target);
        GameObject t = Instantiate(projectile, transform.position, Quaternion.identity);
        t.GetComponent<Rigidbody>().AddForce(transform.forward * 2000);
    }
}
