using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCreationManager : MonoBehaviour {

    // Start is called before the first frame update

    // private string currentSpriteName;

    private int turn; // 0 = player one, 1 = player two

    private GameObject playerOne_redSprite;
    private GameObject playerOne_blueSprite;
    private GameObject playerOne_greenSprite;
    private GameObject playerOne_yellowSprite;

    private GameObject playerTwo_redSprite;
    private GameObject playerTwo_blueSprite;
    private GameObject playerTwo_greenSprite;
    private GameObject playerTwo_yellowSprite;

    public void Start()
    {
        turn = 0;

        playerOne_redSprite = GameObject.Find("playerOne_redKnight");
        playerOne_blueSprite = GameObject.Find("playerOne_blueKnight");
        playerOne_greenSprite = GameObject.Find("playerOne_greenKnight");
        playerOne_yellowSprite = GameObject.Find("playerOne_yellowKnight");

        playerOne_blueSprite.SetActive(false);
        playerOne_greenSprite.SetActive(false);
        playerOne_yellowSprite.SetActive(false);

        playerTwo_redSprite = GameObject.Find("playerTwo_redKnight");
        playerTwo_blueSprite = GameObject.Find("playerTwo_blueKnight");
        playerTwo_greenSprite = GameObject.Find("playerTwo_greenKnight");
        playerTwo_yellowSprite = GameObject.Find("playerTwo_yellowKnight");

        playerTwo_blueSprite.SetActive(false);
        playerTwo_greenSprite.SetActive(false);
        playerTwo_yellowSprite.SetActive(false);


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

    public void PlayerTwoDisplayNextSprite() {

        //for player two

        if (playerTwo_redSprite.activeInHierarchy)
        { // if red active, disable it, then enable blue

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
            playerTwo_yellowSprite.SetActive(true);

        }
        else
        {

            playerTwo_yellowSprite.SetActive(false);
            playerTwo_redSprite.SetActive(true);

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

        // for player two :

        if (playerTwo_yellowSprite.activeInHierarchy)
        {

            playerTwo_yellowSprite.SetActive(false);
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
        else
        {

            playerTwo_redSprite.SetActive(false);
            playerTwo_yellowSprite.SetActive(true);

        }

    }
   

   
    
}
