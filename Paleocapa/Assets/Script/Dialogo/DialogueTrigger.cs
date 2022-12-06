using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public bool fine=false;
	
	public void TriggerDialogue(){
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);// cerco l'oggetto di tipo DialogueManager e posso chiamarci una funzione che avrà come argomento dialogue, ovvero la conversazione
    }
	public void Fine_dialogo(){
		fine=true;
	}
}
