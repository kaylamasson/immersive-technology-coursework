using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public void PlayAudio(){
        this.GetComponent<AudioSource>().Play();
    }
   
}
