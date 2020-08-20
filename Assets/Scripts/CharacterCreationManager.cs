using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCreationManager : MonoBehaviour {

    // Start is called before the first frame update

    // private string currentSpriteName;

   // private int turn; // 0 = player one, 1 = player two

    private GameObject playerOne_redSprite;
    private GameObject playerOne_blueSprite;
    private GameObject playerOne_greenSprite;
    private GameObject playerOne_yellowSprite;

    private GameObject playerTwo_redSprite;
    private GameObject playerTwo_blueSprite;
    private GameObject playerTwo_greenSprite;
    private GameObject playerTwo_yellowSprite;

    private GameObject playerTwo_confirm;
    private GameObject playerTwo_rightScroll;
    private GameObject playerTwo_leftScroll;

    private GameObject playerOne_confirm;
    private GameObject playerOne_rightScroll;
    private GameObject playerOne_leftScroll;

    private string playerOne_selection;
    private string playerTwo_selection;

    public void Start()
    {
       // turn = 0;

        // player one sprites

        playerOne_redSprite = GameObject.Find("playerOne_redKnight");
        playerOne_blueSprite = GameObject.Find("playerOne_blueKnight");
        playerOne_greenSprite = GameObject.Find("playerOne_greenKnight");
        playerOne_yellowSprite = GameObject.Find("playerOne_yellowKnight");

        playerOne_blueSprite.SetActive(false);
        playerOne_greenSprite.SetActive(false);
        playerOne_yellowSprite.SetActive(false);

        // player two sprites

        playerTwo_redSprite = GameObject.Find("playerTwo_redKnight");
        playerTwo_blueSprite = GameObject.Find("playerTwo_blueKnight");
        playerTwo_greenSprite = GameObject.Find("playerTwo_greenKnight");
        playerTwo_yellowSprite = GameObject.Find("playerTwo_yellowKnight");

        playerTwo_redSprite.SetActive(false);
        playerTwo_blueSprite.SetActive(false);
        playerTwo_greenSprite.SetActive(false);
        playerTwo_yellowSprite.SetActive(false);

        // player one buttons

        playerOne_confirm = GameObject.Find("playerOne_confirm");
        playerOne_confirm.GetComponent<Button>().interactable = true;

        playerOne_leftScroll = GameObject.Find("playerOne_leftScroll");
        playerOne_rightScroll = GameObject.Find("playerOne_rightScroll");

        playerOne_leftScroll.GetComponent<Button>().interactable = true;
        playerOne_rightScroll.GetComponent<Button>().interactable = true;

        // player two buttons

        playerTwo_confirm = GameObject.Find("playerTwo_confirm");
        playerTwo_confirm.GetComponent<Button>().interactable = false;

        playerTwo_leftScroll = GameObject.Find("playerTwo_leftScroll");
        playerTwo_rightScroll = GameObject.Find("playerTwo_rightScroll");

        playerTwo_leftScroll.GetComponent<Button>().interactable = false;
        playerTwo_rightScroll.GetComponent<Button>().interactable = false;

    }




    public void PlayerOneDisplayNextSprite() { // changes the sprites

        // order of selection : red, blue, green, yellow

        //for player one :

        if (playerOne_redSprite.activeInHierarchy) { // if red active, disable it, then enable blue

            playerOne_redSprite.SetActive(false);
            playerOne_blueSprite.SetActive(true);

        } else if (playerOne_blueSprite.activeInHierarchy) {

            playerOne_blueSprite.SetActive(false);
            playerOne_greenSprite.SetActive(true);

        } else if (playerOne_greenSprite.activeInHierarchy) {

            playerOne_greenSprite.SetActive(false);
            playerOne_yellowSprite.SetActive(true);

        } else {

            playerOne_yellowSprite.SetActive(false);
            playerOne_redSprite.SetActive(true);

        }


    }


    public void PlayerOneConfirm() {

        playerOne_leftScroll.GetComponent<Button>().interactable = false;
        playerOne_rightScroll.GetComponent<Button>().interactable = false;
        playerOne_confirm.GetComponent<Button>().interactable = false;

        playerTwo_confirm.GetComponent<Button>().interactable = true;
        playerTwo_leftScroll.GetComponent<Button>().interactable = true;
        playerTwo_rightScroll.GetComponent<Button>().interactable = true;
        playerOne_selection = GameObject.FindGameObjectWithTag("PlayerOneSprites").name;
        // Debug.Log("Turn : " + turn);
        Debug.Log("Player One : " + playerOne_selection);


        if (GameObject.FindGameObjectWithTag("PlayerOneSprites").name == "playerOne_redKnight") {

            // Debug.Log("It is working");
            playerTwo_redSprite.SetActive(false);
            playerTwo_blueSprite.SetActive(true);
          
        } else if (GameObject.FindGameObjectWithTag("PlayerOneSprites").name == "playerOne_blueKnight")
        {

            // Debug.Log("It is working");
            playerTwo_blueSprite.SetActive(false);
            playerTwo_redSprite.SetActive(true);

        } else if (GameObject.FindGameObjectWithTag("PlayerOneSprites").name == "playerOne_greenKnight")
        {

            // Debug.Log("It is working");
            playerTwo_greenSprite.SetActive(false);
            playerTwo_redSprite.SetActive(true);

        } else if (GameObject.FindGameObjectWithTag("PlayerOneSprites").name == "playerOne_yellowKnight")
        {

            // Debug.Log("It is working");
            playerTwo_yellowSprite.SetActive(false);
            playerTwo_redSprite.SetActive(true);

        }


    }
   
    public void PlayerTwoDisplayNextSprite() {

        if (playerOne_selection == "playerOne_redKnight") {
            
                if (playerTwo_blueSprite.activeInHierarchy)
                {

                    playerTwo_blueSprite.SetActive(false);
                    playerTwo_greenSprite.SetActive(true);

                }
                else if (playerTwo_greenSprite.activeInHierarchy) {

                    playerTwo_greenSprite.SetActive(false);
                    playerTwo_yellowSprite.SetActive(true);

                } else if (playerTwo_yellowSprite.activeInHierarchy)
                {
                    playerTwo_yellowSprite.SetActive(false);
                    playerTwo_blueSprite.SetActive(true);

                }
                
            } else if (playerOne_selection == "playerOne_blueKnight")
        {

            if (playerTwo_redSprite.activeInHierarchy)
            {

                playerTwo_redSprite.SetActive(false);
                playerTwo_greenSprite.SetActive(true);

            }
            else if (playerTwo_greenSprite.activeInHierarchy)
            {

                playerTwo_greenSprite.SetActive(false);
                playerTwo_yellowSprite.SetActive(true);

            }
            else if (playerTwo_yellowSprite.activeInHierarchy)
            {
                playerTwo_yellowSprite.SetActive(false);
                playerTwo_redSprite.SetActive(true);

            }

        } else if (playerOne_selection == "playerOne_greenKnight")
        {

            if (playerTwo_redSprite.activeInHierarchy)
            {

                playerTwo_redSprite.SetActive(false);
                playerTwo_blueSprite.SetActive(true);

            }
            else if (playerTwo_blueSprite.activeInHierarchy)
            {

                playerTwo_blueSprite.SetActive(false);
                playerTwo_yellowSprite.SetActive(true);

            }
            else if (playerTwo_yellowSprite.activeInHierarchy)
            {
                playerTwo_yellowSprite.SetActive(false);
                playerTwo_redSprite.SetActive(true);

            }

        } else if (playerOne_selection == "playerOne_yellowKnight")
        {

            if (playerTwo_redSprite.activeInHierarchy)
            {

                playerTwo_redSprite.SetActive(false);
                playerTwo_blueSprite.SetActive(true);

            }
            else if (playerTwo_blueSprite.activeInHierarchy)
            {

                playerTwo_blueSprite.SetActive(false);
                playerTwo_greenSprite.SetActive(true);

            }
            else if (playerTwo_greenSprite.activeInHierarchy)
            {
                playerTwo_greenSprite.SetActive(false);
                playerTwo_redSprite.SetActive(true);

            }

        }
        
    }



    public void PlayerOneDisplayBackSprite() {

        //for player one :

        if (playerOne_yellowSprite.activeInHierarchy)
        {

            playerOne_yellowSprite.SetActive(false);
            playerOne_greenSprite.SetActive(true);

        }
        else if (playerOne_greenSprite.activeInHierarchy)
        {

            playerOne_greenSprite.SetActive(false);
            playerOne_blueSprite.SetActive(true);

        }
        else if (playerOne_blueSprite.activeInHierarchy)
        {

            playerOne_blueSprite.SetActive(false);
            playerOne_redSprite.SetActive(true);

        }
        else {

            playerOne_redSprite.SetActive(false);
            playerOne_yellowSprite.SetActive(true);

        }

    }
    
    public void PlayerTwoDisplayBackSprite() {

        if (playerOne_selection == "playerOne_redKnight")
        {

            if (playerTwo_blueSprite.activeInHierarchy)
            {

                playerTwo_blueSprite.SetActive(false);
                playerTwo_yellowSprite.SetActive(true);

            }
            else if (playerTwo_yellowSprite.activeInHierarchy)
            {

                playerTwo_yellowSprite.SetActive(false);
                playerTwo_greenSprite.SetActive(true);

            }
            else if (playerTwo_greenSprite.activeInHierarchy)
            {
                playerTwo_greenSprite.SetActive(false);
                playerTwo_blueSprite.SetActive(true);

            }

        }
        else if (playerOne_selection == "playerOne_blueKnight")
        {

            if (playerTwo_redSprite.activeInHierarchy)
            {

                playerTwo_redSprite.SetActive(false);
                playerTwo_yellowSprite.SetActive(true);

            }
            else if (playerTwo_yellowSprite.activeInHierarchy)
            {

                playerTwo_yellowSprite.SetActive(false);
                playerTwo_redSprite.SetActive(true);

            }
            else if (playerTwo_greenSprite.activeInHierarchy)
            {
                playerTwo_greenSprite.SetActive(false);
                playerTwo_redSprite.SetActive(true);

            }

        }
        else if (playerOne_selection == "playerOne_greenKnight")
        {

            if (playerTwo_redSprite.activeInHierarchy)
            {

                playerTwo_redSprite.SetActive(false);
                playerTwo_yellowSprite.SetActive(true);

            }
            else if (playerTwo_yellowSprite.activeInHierarchy)
            {

                playerTwo_yellowSprite.SetActive(false);
                playerTwo_blueSprite.SetActive(true);

            }
            else if (playerTwo_blueSprite.activeInHierarchy)
            {
                playerTwo_blueSprite.SetActive(false);
                playerTwo_redSprite.SetActive(true);

            }

        }
        else if (playerOne_selection == "playerOne_yellowKnight")
        {

            if (playerTwo_redSprite.activeInHierarchy)
            {

                playerTwo_redSprite.SetActive(false);
                playerTwo_greenSprite.SetActive(true);

            }
            else if (playerTwo_greenSprite.activeInHierarchy)
            {

                playerTwo_greenSprite.SetActive(false);
                playerTwo_blueSprite.SetActive(true);

            }
            else if (playerTwo_blueSprite.activeInHierarchy)
            {
                playerTwo_blueSprite.SetActive(false);
                playerTwo_redSprite.SetActive(true);

            }

        }


    }


    public void PlayerTwoConfirm()
    {
        playerTwo_confirm.GetComponent<Button>().interactable = false;
        playerTwo_leftScroll.GetComponent<Button>().interactable = false;
        playerTwo_rightScroll.GetComponent<Button>().interactable = false;

        playerTwo_selection = GameObject.FindGameObjectWithTag("PlayerTwoSprites").name;
        Debug.Log("Player Two : " + playerTwo_selection);


    }




}
