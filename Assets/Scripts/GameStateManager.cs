using UnityEngine;

public class GameStateManager : MonoBehaviour
{



    public bool puzzleComplete;  

    [SerializeField] GameObject appleCrate;
    [SerializeField] GameObject bananaCrate; 
    [SerializeField] GameObject orangeCrate; 
    [SerializeField] GameObject watermelonCrate; 

    // [SerializeField] GameObject[] fruitCrates = {appleCrate, bananaCrate, orangeCrate, watermelonCrate};

    private bool appleDone;
    private bool bananaDone;
    private bool orangeDone;
    private bool watermelonDone;

    [SerializeField] AudioSource winSound;
    

    // Update is called once per frame
    void Update()
    {
        CheckAllFruits();   
    }


    // void CheckApple()
    // {
    //    if (allFruitsMatched[0] == false)
    //    { 
    //     if (appleCrate.GetComponent<FruitMatch>().getFruitMatched() == true){
    //         allFruitsMatched[0] = true;
    //     }
    //    }
    // }

    // void CheckBanana()
    // {
    //    if (allFruitsMatched[1] == false)
    //    { 
    //     if (bananaCrate.GetComponent<FruitMatch>().getFruitMatched() == true){
    //         allFruitsMatched[1] = true;
    //     }
    //    }
    // }

    // void CheckOrange()
    // {
    //    if (allFruitsMatched[2] == false)
    //    { 
    //     if (orangeCrate.GetComponent<FruitMatch>().getFruitMatched() == true){
    //         allFruitsMatched[2] = true;
    //     }
    //    }
    // }

    //  void CheckWatermelon()
    // {
    //    if (allFruitsMatched[3] == false)
    //    { 
    //     if (watermelonCrate.GetComponent<FruitMatch>().getFruitMatched() == true){
    //         allFruitsMatched[3] = true;
    //     }
    //    }
    // }

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
                winSound.Play(1);

                // appleCrate.SetActive(false);
                // bananaCrate.SetActive(false);

            }
        }
    }   


    //     CheckApple();
    //     CheckBanana();
    //     CheckOrange();
    //     CheckWatermelon(); 

    //     for (int i = 0; i < allFruitsMatched.Length; i++) {
    //         if (allFruitsMatched[i] == true){
    //             puzzleComplete = true; 
    //         } else { 
    //             puzzleComplete = false;
    //         }
            
    //     }

    //     if (puzzleComplete == true){
    //         Debug.Log("Puzzle complete");
    //         appleCrate.SetActive(false); 

    //     }
    }

