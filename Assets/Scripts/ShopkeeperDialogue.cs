using UnityEngine;
using TMPro; 

public class ShopkeeperDialogue : MonoBehaviour
{
    string[] initial_dialogue = new string[] {"Welcome to the local supermarket! We sell a little bit of everything.",
    "Well, we will... once I get energy to power the fridges inside. For now help yourself to fruit, fruit and more fruit.",
    "You'll find me a solar panel? That would be so helpful!"};

    string[] panel_dialogue = new string[] {"Amazing! I'm so grateful. I'll go get these fridges started now, thank you!", 
                                            "I have a spare key I can give you, see if you can find where to use it."};

    [SerializeField] TMP_Text dialogue_text; 
    [SerializeField] GameObject startButton;
    [SerializeField] GameObject dialogueSystem; 
    [SerializeField] GameObject key;

    // [SerializeField] GameObject solarPanel_grabbable; 


    private bool panelReturned; 

    private int counter;

    void Start()
    {
        key.gameObject.SetActive(false);
        counter = 0; 
        dialogueSystem.gameObject.SetActive(false);
        startButton.gameObject.SetActive(false);
        panelReturned = false; 


    }

    void OnTriggerEnter(Collider other)
    {

        if (other.tag=="Player" && panelReturned == false){
            startButton.gameObject.SetActive(true);
            ShowMessage(initial_dialogue[0]);
            counter ++; 
        } else if (other.tag=="solarPanel"){

            dialogueSystem.gameObject.SetActive(true);
            ShowMessage(panel_dialogue[0]); 
            counter ++; 
            panelReturned = true;


            //Hide solar panel game object
            other.gameObject.SetActive(false);


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
        if (panelReturned == false){
            
            if (counter < initial_dialogue.Length){
            ShowMessage(initial_dialogue[counter]);
            counter ++; 

            } else {
                counter = 0; 
                dialogueSystem.SetActive(false);
            }
        } else {

            if (counter < panel_dialogue.Length){
            ShowMessage(panel_dialogue[counter]);
            counter ++; 

            } else { 
                counter = 0; 
                dialogueSystem.SetActive(false);
                key.gameObject.SetActive(true);

            }
    
        }



    }
}

