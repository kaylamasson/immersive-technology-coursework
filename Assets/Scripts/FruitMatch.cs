using UnityEngine;

public class FruitMatch : MonoBehaviour
{
    
    public bool fruitMatched;
    [SerializeField] AudioSource correctSound;

                                     
    void OnCollisionEnter (Collision other)
    {
        if (other.gameObject.tag == this.gameObject.tag){
            fruitMatched = true;
            Debug.Log("fruit match");
            correctSound.Play();
        }
    }

    void OnCollisionExit (Collision other)
    {
        if (other.gameObject.tag == this.gameObject.tag){
            fruitMatched = false;
        }
    }

    public bool getFruitMatched()
    {
        return fruitMatched; 
    }

}
