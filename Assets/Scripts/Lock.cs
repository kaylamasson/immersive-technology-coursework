using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{

   [SerializeField] GameObject gate;
   [SerializeField] GameObject key;

    private bool locked;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        locked = true;
        gate.GetComponent<Rigidbody>().isKinematic = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Key" && locked)
        {   
            //ensure right key is used
            //make keys have unique names 

            if (other.gameObject.name == key.gameObject.name)
            {
              UnlockGate();
            }
        }
    }

    private void UnlockGate()
    {
        gate.GetComponent<Rigidbody>().isKinematic = false;
        this.GetComponent<Rigidbody>().isKinematic = false;
        this.GetComponent<BoxCollider>().isTrigger = false;

        locked = false;

        this.GetComponent<AudioSource>().Play();

    }
    
}
