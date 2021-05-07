using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrig : MonoBehaviour
{
    public DialogueObj dialogue;

    public void TriggerDialogue ()
    {
        FindObjectOfType<Dialogue>().StartDialogue(dialogue);
    }
}
