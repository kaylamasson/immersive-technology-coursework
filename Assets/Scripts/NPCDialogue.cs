using UnityEngine;
using TMPro; 

public class NPCDialogue : MonoBehaviour
{
    string[] initial_dialogue = new string[] {"Hey look at this cool solar panel I found!", 
    "Oh, you're looking for one of these? Hmm...", 
    "How about a trade?", 
    "I lost my lucky hat while I was fishing by the lake earlier.",
    "Bring me my hat and I'll give you this solar panel!"};

    string[] hat_dialogue = new string[] {"You found my hat! Thank you so much.", 
                                            "Here, take this solar panel."};

    [SerializeField] TMP_Text dialogue_text; 
    [SerializeField] GameObject startButton;
    [SerializeField] GameObject dialogueSystem; 
    [SerializeField] GameObject NPC_hat; 
    [SerializeField] GameObject hat_object;

    [SerializeField] GameObject solarPanel_static; 
    [SerializeField] GameObject solarPanel_grabbable; 


    private bool hatReturned; 

    private int counter;

    private AudioSource winNoise;

    void Start()
    {
        counter = 0; 
        dialogueSystem.gameObject.SetActive(false);
        startButton.gameObject.SetActive(false);
        hatReturned = false; 

        solarPanel_static.SetActive(true); 
        solarPanel_grabbable.SetActive(false); 

        hat_object.SetActive(false); 

        winNoise = this.GetComponent<AudioSource>(); 

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.tag=="Player" && hatReturned == false){

            startButton.gameObject.SetActive(true);
            ShowMessage(initial_dialogue[0]);
            counter ++; 
            hat_object.SetActive(true); 

        } else if (other.tag=="Hat"){

            dialogueSystem.gameObject.SetActive(true);
            ShowMessage(hat_dialogue[0]); 
            counter ++; 
            hatReturned = true;

            //hat appears back on NPC
            NPC_hat.SetActive(true);

            //Hide hat game object
            other.gameObject.SetActive(false);

            winNoise.Play(); 


        }

    }

    void OnTriggerExit(Collider other)
    {

        startButton.gameObject.SetActive(false); 

    }

    void ShowMessage(string message)
    {
        dialogue_text.text = message;
    }

    public void NextDialogue()
    {
        if (hatReturned == false){
            
            if (counter < initial_dialogue.Length){
            ShowMessage(initial_dialogue[counter]);
            counter ++; 

            } else {
                counter = 0; 
                dialogueSystem.SetActive(false);
            }
        } else {

            if (counter < hat_dialogue.Length){
            ShowMessage(hat_dialogue[counter]);
            counter ++; 

            } else { 
                counter = 0; 
                dialogueSystem.SetActive(false);
                solarPanel_static.SetActive(false); 
                solarPanel_grabbable.SetActive(true); 

            }
    
        }



    }

    public void PlaySound()
    {
        this.GetComponent<AudioSource>().Play(); 
    }
}

