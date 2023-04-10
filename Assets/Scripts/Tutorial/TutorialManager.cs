using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject[] popUps;
    private int popUpIndex = 0;
    public ItemJumpCard itemJumpCard;
    bool collide = false;
    bool check = false;

    // Start is called before the first frame update
    void Start()
    {
        itemJumpCard.collideEvent += checkCollide;
    } 

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < popUps.Length; i++)
        {
            if (i == popUpIndex){
                if(check == false){
                    popUps[i].SetActive(true);
                    Invoke("disappear", 5);
                    check = true;
                }
                
            } else {
                popUps[i].SetActive(false);
            }
        }
        if(popUpIndex == 0){
            if(Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.A)||Input.GetKeyDown(KeyCode.S)||Input.GetKeyDown(KeyCode.D)){
                check = false;
                popUpIndex++;
            }  
        } else if (popUpIndex == 1){
            if (ShowRemain.instance.check == true){
                check = false;
                popUpIndex++;
            }
        } 
        else if (popUpIndex == 2){
            if (PlayerController.instance.isMovingRight == true){
                check = false;
                popUpIndex++;
            }
        } else if (popUpIndex == 3){
            if(collide){
                check = false;
                popUpIndex++;
            }
        } else if (popUpIndex == 4){
            if(hintpoint.instance.check == true){
                check = false;
                popUpIndex++;
            }
        } else if (popUpIndex == 5){
            if(hintpoint2.instance.check == true){
                check = false;
                popUpIndex++;
            }  
        } else if (popUpIndex == 6){
            if(hintpoint3.instance.check == true){
                check = false;
                popUpIndex++;
            }
        } else if (popUpIndex == 7){
            if(hintpoint4.instance.check == true){
                check = false;
                popUpIndex++;
            }
        } else if (popUpIndex == 8){
            if(hintpoint5.instance.check == true){
                check = false;
                popUpIndex++;
            }
        } 
    }

    void disappear()
    {
        popUps[popUpIndex].SetActive(false);
    }
    void checkCollide()
    {
        collide = true;
    }
}
