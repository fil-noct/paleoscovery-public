using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ToDialogue2 : MonoBehaviour
{
	public UnityEvent ev; 
	
	private void OnTriggerEnter2D(Collider2D collision)
    {
		
		
        if (collision.gameObject.tag == "Player")
        {
			Debug.Log("Colliso");
			
			ev.Invoke();
			
        }
    }
}
