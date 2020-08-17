using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManagerTest : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;

    private Queue<string> sentences;
    private Queue<string> names;

    public DialogueManagerTest()
    {

        sentences = new Queue<string>();
        names = new Queue<string>();
        

    }

    // Start is called before the first frame update
    void Start()
    {

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


    public void DisplayNextDialogue() {

        DisplayNextName();
        DisplayNextSentence();


    }



    void EndDialogue()
    {

        Debug.Log("End of convo.");

    }
}
