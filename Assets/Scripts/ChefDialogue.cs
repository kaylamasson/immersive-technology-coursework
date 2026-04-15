using UnityEngine;
using TMPro; 

public class ChefDialogue : MonoBehaviour
{
    string[] initial_dialogue = new string[] {"My cafe is almost all set up!",
    "Only one tiny problem... I don't have any power to use my oven.",
    "With no power I can't cook any of my delicious food. And with no food I can't feed any hungry customers!",
    "Oh, will you help me? Bring me a solar panel so I can start baking?"};

    string[] panel_dialogue = new string[] {"Great! Now I can power my oven and start baking.", 
                                            "I'll finally be able to make some food for the customers, thank you so much!",
                                            "Here's a coin, treat yourself to something from the Trendy Gift Shop!"};

    [SerializeField] TMP_Text dialogue_text; 
    [SerializeField] GameObject startButton;
    [SerializeField] GameObject dialogueSystem; 

    [SerializeField] GameObject cafeSolarPanel; 

    [SerializeField] GameObject coin; 

    // [SerializeField] GameObject solarPanel_grabbable; 


    private bool panelReturned; 

    private int counter;

    void Start()
    {
        counter = 0; 
        dialogueSystem.gameObject.SetActive(false);
        startButton.gameObject.SetActive(false);
        panelReturned = false; 
        cafeSolarPanel.SetActive(false);
        coin.SetActive(false);


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
            cafeSolarPanel.SetActive(true);
            coin.SetActive(true);



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
            }
    
        }



    }
}

