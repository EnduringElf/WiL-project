using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour 
{

    [SerializeField] DialogueManager dialogueManager;
    [SerializeField] Dialogue dialogue;

    public string GetDescription()
    {
        return "Talk to Bob";
    }

    public void onTriggerEnter()
    {
        dialogueManager.BeginDialogue(dialogue);
    }

   
}

