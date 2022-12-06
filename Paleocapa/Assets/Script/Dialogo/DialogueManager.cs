using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    public Text nameText;
    public Text dialogueText;
    public Animator animator;
    
	private Queue<string> sentences;	//FIFO collection, hahah fofo
    public int nsent;
	void Start(){
        sentences = new Queue<string>();
    }
    public void StartDialogue(Dialogue dialogue){
        animator.SetBool("isOpen", true);
        nameText.text = dialogue.name;
        sentences.Clear();

        foreach(string sentence in dialogue.sentences){
            sentences.Enqueue(sentence);

        }

        DisplayNextSentence();
    }
    public void DisplayNextSentence(){
		nsent=sentences.Count;
        if(sentences.Count == 0){
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }
    IEnumerator TypeSentence (string sentence){
        dialogueText.text = "";
        foreach(char letter in sentence.ToCharArray()){
            dialogueText.text += letter;
            yield return null; //aspetta un frame
        }
    }
    void EndDialogue(){
        animator.SetBool("isOpen", false);
    }
}
