using UnityEngine;

public class GiftShop : MonoBehaviour
{

    [SerializeField] GameObject shopMenu; //shop menu UI canvas
    [SerializeField] GameObject purchasedMenu; //shop menu UI canvas
    [SerializeField] GameObject gift;
    [SerializeField] AudioSource gift_audio;
    
    private bool purchased = false;

    void Start()
    {

    //make shop menu hidden on game load
      shopMenu.SetActive(false); 
      purchasedMenu.SetActive(false);  
      gift.SetActive(false); 
      purchased = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (purchased == false){
            
            shopMenu.SetActive(true); 


            if (other.tag == "Coin"){
                other.gameObject.SetActive(false);
                GiveGift(); 
            }
        }

       
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player"){
            shopMenu.SetActive(false); 
        }
    }


    void GiveGift()
    {
        purchased = true;
        gift.SetActive(true); 
        gift_audio.Play();
        shopMenu.SetActive(false);
        purchasedMenu.SetActive(true);

    }
    
}
