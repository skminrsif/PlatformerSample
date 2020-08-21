using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManagerTest : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    public Image introImage;

    private Queue<string> sentences;
    private Queue<string> names;
    private Queue<int> images;
    // private Queue<Image> images;

    private GameObject intro_1;
    private GameObject intro_2;
    private GameObject intro_3;
    private GameObject intro_4;
    private GameObject intro_5;
    private GameObject intro_6;
    private GameObject black;
    
    public DialogueManagerTest()
    {

        sentences = new Queue<string>();
        names = new Queue<string>();
        images = new Queue<int>();
        // images = new Queue<Image>();
        

    }

    // Start is called before the first frame update
    void Start()
    {

        intro_1 = GameObject.Find("intro 1");
        intro_2 = GameObject.Find("intro 2");
        intro_3 = GameObject.Find("intro 3");
        intro_4 = GameObject.Find("intro 4");
        intro_5 = GameObject.Find("intro 5");
        intro_6 = GameObject.Find("intro 6");
        black = GameObject.Find("black");

        intro_2.SetActive(false);
        intro_3.SetActive(false);
        intro_4.SetActive(false);
        intro_5.SetActive(false);
        intro_6.SetActive(false);
        black.SetActive(false);

        // sentences = new Queue<string>();

    }

    public void StartDialogue(Dialogue dialogue)
    {
        foreach (string name in dialogue.names)
        {

            names.Enqueue(name);

        }

        DisplayNextName();

        // nameText.text = dialogue.name;


        // sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {

            sentences.Enqueue(sentence);

        }

        Debug.Log("Sentence count : " + sentences.Count);
        DisplayNextSentence();

        foreach (int image in dialogue.images)
        {

            images.Enqueue(image);

        }

        DisplayNextName();


    }

    
    public void DisplayNextSentence()
    {

        if (sentences.Count == 0)
        {

            EndDialogue();
            return;

        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;

    }


    public void DisplayNextName()
    {

        if (names.Count == 0)
        {

            EndDialogue();
            return;

        }

        string name = names.Dequeue();
        nameText.text = name;

    }

    public void DisplayNextImage() {

        if (images.Count == 0) {


            EndDialogue();
            return;



        }

        int image = images.Dequeue();

        if (image == 1)
        {

            GameObject.FindGameObjectWithTag("IntroImages").SetActive(false);
            intro_1.SetActive(true);

        }
        else if (image == 2) {

            GameObject.FindGameObjectWithTag("IntroImages").SetActive(false);
            intro_2.SetActive(true);

        }
        else if (image == 3)
        {

            GameObject.FindGameObjectWithTag("IntroImages").SetActive(false);
            intro_3.SetActive(true);

        }
        else if (image == 4)
        {

            GameObject.FindGameObjectWithTag("IntroImages").SetActive(false);
            intro_4.SetActive(true);

        }
        else if (image == 5)
        {

            GameObject.FindGameObjectWithTag("IntroImages").SetActive(false);
            intro_5.SetActive(true);

        }
        else if (image == 6)
        {

            GameObject.FindGameObjectWithTag("IntroImages").SetActive(false);
            intro_6.SetActive(true);

        }
        else if (image == 0)
        {

            GameObject.FindGameObjectWithTag("IntroImages").SetActive(false);
            black.SetActive(true);

        }


    }


    public void DisplayNextDialogue() {

        DisplayNextName();
        DisplayNextSentence();
        DisplayNextImage();

    }

  



    void EndDialogue()
    {

        Debug.Log("End of convo.");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    

    }
}
