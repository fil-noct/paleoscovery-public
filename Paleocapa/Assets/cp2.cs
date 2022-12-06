using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class cp2 : MonoBehaviour
{
	public string word="NESE";
	public string attWord;
	public bool comp;
	public UnityEvent fine;
	
	public GameObject abb;
	
    // Start is called before the first frame update
    void Start()
    {
        attWord="";
		comp=false;
    }

    // Update is called once per frame
    void Update()
    {
		attWord="";
        GameObject lett = GameObject.Find("1lett");
        Change_lett chlet = lett.GetComponent<Change_lett>();
		attWord += chlet.lettAtt;
		
		lett = GameObject.Find("1lett1");
		chlet = lett.GetComponent<Change_lett>();
		attWord += chlet.lettAtt;
		
		lett = GameObject.Find("1lett2");
        chlet = lett.GetComponent<Change_lett>();
		attWord += chlet.lettAtt;
		
		lett = GameObject.Find("1lett3");
        chlet = lett.GetComponent<Change_lett>();
		attWord += chlet.lettAtt;
	
		if(word==attWord){
			comp=true;
			fine.Invoke();
			
		}
		
    }
}
