using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void Update()
    {
        
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Application.LoadLevel(Application.loadedLevel);
        } 
    }
}
