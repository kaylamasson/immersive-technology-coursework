using UnityEngine;

public class GiftShop : MonoBehaviour
{

    [SerializeField] GameObject shopMenu; //shop menu UI canvas
    void Start()
    {

    //make shop menu hidden on game load
      shopMenu.SetActive(false);   
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player"){
            shopMenu.SetActive(true); 
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player"){
            shopMenu.SetActive(false); 
        }
    }


    void CheckCoins()
    {
        // if player has coin
            // give player trophy
    }


}
