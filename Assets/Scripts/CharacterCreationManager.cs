using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCreationManager : MonoBehaviour {
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {

        DisplayNextSprite();
        
    }


    public void DisplayNextSprite() { // changes the sprites

        // order of selection : red, blue, green, yellow

      if (GameObject.Find("red").activeInHierarchy) { // if red active, disable it, then enable blue

            GameObject.Find("red").SetActive(false);
            GameObject.Find("blue").SetActive(true);
            Debug.Log("It is working.");
        }
        
    }

    //public bool getActiveSprite() {

    //    string currentActiveSprite_PlayerOne = GameObject.FindGameObjectWithTag("PlayerOneSprites").name;
    //    Debug.Log(currentActiveSprite_PlayerOne);

    //    return GameObject.Find(currentActiveSprite_PlayerOne).activeInHierarchy;

    //}
    
}
