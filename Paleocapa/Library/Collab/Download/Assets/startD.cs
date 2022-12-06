using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class startD : MonoBehaviour
{
	public UnityEvent cliccatog;
	public UnityEvent nextD;
	public bool ok=false;
	private int sent;
	
	
	
	public void iniD()
    {
        cliccatog.Invoke();
		Debug.Log("Partito");
		ok=true;
    }
	
    // Update is called once per frame
    void Update()
    {
		
		GameObject dm = GameObject.Find("DialogueManager");
        DialogueManager dms = dm.GetComponent<DialogueManager>();
		sent = dms.nsent;
		
		if(ok){
				
			if(sent == 0){
				nextD.Invoke();
			}
			
		}
		
		
    }
}
