using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    private Queue<string> sentences;

    public Text nameText;
    public Text dialogueText;

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(DialogueObj dialogue)
    {
        nameText.text = dialogue.name;

        foreach  (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

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

    void EndDialogue()
    {

    }
}
 