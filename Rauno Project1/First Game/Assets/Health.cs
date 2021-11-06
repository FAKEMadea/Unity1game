using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public GameObject myHealth;
    public GameObject spawner;
    public GameObject wintext;
    public int health;
    public GameObject instructions;
    
    void Start()
    {
        health = 10;
        myHealth.GetComponent<Text>().text = "Health: " + health;
    }

    
    void Update()
    {
        myHealth.GetComponent<Text>().text = "Health: " + health;
        if (health <= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel(Application.loadedLevel);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
            Debug.Log("See lõpetab mängu");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Damage")
        {
            health--;
        }

        if (collision.gameObject.tag == "finish")
        {
            spawner.SetActive(true);
            wintext.SetActive(true);
            instructions.SetActive(true);
            
        }
    }
}
