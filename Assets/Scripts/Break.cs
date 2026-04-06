using UnityEngine;

public class Break : MonoBehaviour
{
    public Rigidbody rb;

    private bool breakable;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.isKinematic = true;
        breakable = false; 
        
    }

    // Update is called once per frame
    void Update()
    {
        if (breakable==true){
            rb.isKinematic = false;
        } else {
            rb.isKinematic= true; 
        }
    }

    void OnCollisionEnter(Collision other){
        if (other.gameObject.tag == "Shovel"){
            breakable = true; 
        } else if (other.gameObject.tag == "Player"){
            breakable = false;
        }
    }
}
