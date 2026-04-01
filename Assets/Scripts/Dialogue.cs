using UnityEngine;

public class Dialogue : MonoBehaviour
{

    [SerializeField] GameObject solarPanel;
    [SerializeField] GameObject dialogue; 

    private bool panelFound;

    void Start()
    {
      panelFound = false;
      dialogue.gameObject.SetActive(false);   
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag=="solarPanel" && panelFound == false){
                panelFound=true;
                dialogue.gameObject.SetActive(true);
                solarPanel.gameObject.SetActive(false);

        }
    }


}
