using UnityEngine;
using TMPro; 

public class FarmerDialogue : MonoBehaviour
{
    string[] initial_dialogue = new string[] {"Can you help me? I need help to power my barn.",
    "I've just finished building my farm but I need energy to keep the animals warm at night.",
    "If you find a solar panel please bring it to me!"};

    string[] panel_dialogue = new string[] {"Wow you got a solar panel! Thank you so much.", 
                                            "I'll give you this shovel, it might come in handy for exploring this town."};

    [SerializeField] TMP_Text dialogue_text; 
    [SerializeField] GameObject startButton;
    [SerializeField] GameObject dialogueSystem; 
    [SerializeField] GameObject shovel; 

    [SerializeField] GameObject barnSolarPanel;

    [SerializeField] GameObject solarPanelObject;

    // [SerializeField] GameObject solarPanel_grabbable; 


    private bool panelReturned; 

    private int counter;

    void Start()
    {
        counter = 0; 
        dialogueSystem.gameObject.SetActive(false);
        startButton.gameObject.SetActive(false);
        panelReturned = false; 
        shovel.gameObject.SetActive(false); 
        barnSolarPanel.SetActive(false);
        solarPanelObject.SetActive(false);

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.tag=="Player" && panelReturned == false){
            startButton.gameObject.SetActive(true);
            ShowMessage(initial_dialogue[0]);
            counter ++; 
            solarPanelObject.SetActive(true);
            
        } else if (other.tag=="solarPanel"){

            dialogueSystem.gameObject.SetActive(true);
            ShowMessage(panel_dialogue[0]); 
            counter ++; 
            panelReturned = true;
            barnSolarPanel.SetActive(true);

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
                shovel.gameObject.SetActive(true);
            }
    
        }



    }
}

