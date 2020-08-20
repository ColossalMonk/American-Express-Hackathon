﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    public void Start()
    {
        StartCoroutine(Trigger());
    }

    IEnumerator Trigger()
    {
        yield return new WaitForSeconds(1f);
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
