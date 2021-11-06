using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject spawnee;
   
    void Start()
    {
        
    }

    
    void Update()
    {
        Instantiate(spawnee, transform.position, Quaternion.identity);
    }
}
