using UnityEngine;

public class DestroyRock : MonoBehaviour
{

    private int health; 
    private bool hitGround;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hitGround = false;
        health = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    { 
        //Destroy rock if hit 3 times or it falls onto the ground

        if (health < 3 || hitGround == false) 
        {
            if (other.gameObject.tag == "Shovel")
            {
                health ++; 
            } else if (other.gameObject.tag == "Ground")
            {
                hitGround = true;
            }
        } else 
        { 
            Destroy(this.gameObject, 2); 
        }
    }
}
