using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class ToDialogue1 : MonoBehaviour
{
	public UnityEvent active;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            active.Invoke();
			
        }
    }
}
