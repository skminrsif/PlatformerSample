﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

    public Dialogue dialogue;

    public void TriggerDialogue() {

        FindObjectOfType<DialogueManagerTest>().StartDialogue(dialogue);

    }

    public void Start()
    {
        TriggerDialogue();

    }


}
