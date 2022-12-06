using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enigmatoccato : MonoBehaviour
{
	public bool et=false;
	public Renderer rend;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
		et=false;
        if (collision.gameObject.tag == "Player")
        {
			et=true;
			
			rend = GetComponent<Renderer>();
			gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
			
		
    }
}
