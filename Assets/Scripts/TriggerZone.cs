using System.Collections;
using System.Collections.Generic; 
using UnityEngine;
using UnityEngine.XR;

public class TriggerZone : MonoBehaviour
{
    [SerializeField] GameObject hat;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            hat.gameObject.SetActive(false);
        }
    }
}
