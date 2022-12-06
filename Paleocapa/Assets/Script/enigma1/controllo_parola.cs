using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class controllo_parola : MonoBehaviour
{
	public string word="POVEGLIA";
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
        GameObject lett = GameObject.Find("lett");
        Change_lett chlet = lett.GetComponent<Change_lett>();
		attWord += chlet.lettAtt;
		
		lett = GameObject.Find("lett1");
		chlet = lett.GetComponent<Change_lett>();
		attWord += chlet.lettAtt;
		
		lett = GameObject.Find("lett2");
        chlet = lett.GetComponent<Change_lett>();
		attWord += chlet.lettAtt;
		
		lett = GameObject.Find("lett3");
        chlet = lett.GetComponent<Change_lett>();
		attWord += chlet.lettAtt;
		
		lett = GameObject.Find("lett4");
        chlet = lett.GetComponent<Change_lett>();
		attWord += chlet.lettAtt;
		
		lett = GameObject.Find("lett5");
        chlet = lett.GetComponent<Change_lett>();
		attWord += chlet.lettAtt;
		
		lett = GameObject.Find("lett6");
        chlet = lett.GetComponent<Change_lett>();
		attWord += chlet.lettAtt;
		
		lett = GameObject.Find("lett7");
        chlet = lett.GetComponent<Change_lett>();
		attWord += chlet.lettAtt;
		
		lett = GameObject.Find("lett8");
        chlet = lett.GetComponent<Change_lett>();
		attWord += chlet.lettAtt;
		
		
		if(word==attWord){
			comp=true;
			fine.Invoke();
		}
		
    }
}
