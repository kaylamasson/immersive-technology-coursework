using UnityEngine;

public class DestroyRock : MonoBehaviour
{

    private int health; 

    void Start()
    {
        health = 0;
    }

    

    void OnCollisionEnter(Collision other)
    { 
        //Destroy rock if hit 3 times or it falls onto the ground

        if (health < 2) 
        {
            if (other.gameObject.tag == "Shovel")
            {
                health ++; 
            } 
        } else 
        { 
            Destroy(this.gameObject, 1); 
        }
    }
}
