using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Enigma2Comp : MonoBehaviour
{
    public bool encomp = false;
    public GameObject minicoso;
	public UnityEvent fine;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Pallina")
        {
            encomp = true;
			fine.Invoke();
        }
    }
}
