using UnityEngine;

public class BreakWall : MonoBehaviour
{
    private bool wallBreak;

    public GameObject[] rocks;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //this.gameObject.isStatic = true;
        for(int i = 0; i < rocks.Length; i++) {

            rocks[i].GetComponent<Rigidbody>().isKinematic = true;
        }
    }


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag=="Shovel" && wallBreak == false)
        {
            // this.gameObject.isStatic = false;
            RockFall();

            wallBreak = true;
        }
    }

    void RockFall()
    {
       for(int i = 0; i < rocks.Length; i++) {

            rocks[i].GetComponent<Rigidbody>().isKinematic = false;

        }
    }
}
