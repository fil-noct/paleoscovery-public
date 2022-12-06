using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour
{
    // Start is called before the first frame update
	public Renderer sp;
	void Update()
    {
		
        if (gameObject.GetComponent<enigmatoccato>().et)
        {
			sp.enabled=false;
        }
			
		
    }
}
