using UnityEngine;

public class GameStateManager : MonoBehaviour
{



    public bool puzzleComplete;  

    [SerializeField] GameObject appleCrate;
    [SerializeField] GameObject bananaCrate; 
    [SerializeField] GameObject orangeCrate; 
    [SerializeField] GameObject watermelonCrate; 


    private bool appleDone;
    private bool bananaDone;
    private bool orangeDone;
    private bool watermelonDone;

    [SerializeField] AudioSource winSound;

    [SerializeField] GameObject chest; 
    [SerializeField] Animator animator;

    void Start()
    {
        animator = chest.GetComponent<Animator>(); // get animator from chest
    }
    // Update is called once per frame
    void Update()
    {
        CheckAllFruits();   
    }

    void CheckAllFruits()
    {
        if (puzzleComplete == false)
        {
            if (appleDone == false){
                if (appleCrate.GetComponent<FruitMatch>().getFruitMatched() == true){
                    appleDone = true;
                }
            }
            if (bananaDone == false){
                if (bananaCrate.GetComponent<FruitMatch>().getFruitMatched() == true){
                    bananaDone = true;
                }
            }
            if (orangeDone == false){
                if (orangeCrate.GetComponent<FruitMatch>().getFruitMatched() == true){
                    orangeDone = true;
                }
            }
            if (watermelonDone == false){
                if (watermelonCrate.GetComponent<FruitMatch>().getFruitMatched() == true){
                    watermelonDone = true;
                }
            }

            if (appleDone && bananaDone && orangeDone && watermelonDone)
            {
                puzzleComplete = true;
                OpenChest();
            }
        }

        void OpenChest()
        {
            winSound.Play(1);
            animator.SetBool("open", true); 
        }
    }   
}

