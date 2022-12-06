
using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;
	public bool en1 = false;
	public bool en2 = false;
	bool en0 = false;
	bool enT1 = false;
	bool enT2 = false;
	
	public bool storia1 = false;
	public bool storia1ok = false;
	bool nxt1=true;
	
	public bool storia2 = false;
	public bool storia2ok = false;
	bool nxt2=false;
	
	public Animator anim;
	
	public bool FollowPlayer=true;
	
    void Update()
    {
		GameObject eni1 = GameObject.Find("cryptex");
        controllo_parola chlet = eni1.GetComponent<controllo_parola>();
		en1 = chlet.comp;
		
		GameObject enigc1 = GameObject.Find("Enigma1_Cucciolo");
        enigmatoccato enit1 = enigc1.GetComponent<enigmatoccato>();
		enT1 = enit1.et;
		
		GameObject eni2 = GameObject.Find("Buco");
        Enigma2Comp enicomp = eni2.GetComponent<Enigma2Comp>();
		en2 = enicomp.encomp;
		
		GameObject enigc2 = GameObject.Find("Enigma2_Cucciolo");
        enigmatoccato enit2 = enigc2.GetComponent<enigmatoccato>();
		enT2 = enit2.et;
		
		GameObject eni0 = GameObject.Find("sfondo biblioteca");
        Enigma0Comp eni0comp = eni0.GetComponent<Enigma0Comp>();
		en0 = eni0comp.comp;
		
		GameObject s1d = GameObject.Find("s1dialogo finale");
        DialogueTrigger ss1d = s1d.GetComponent<DialogueTrigger>();
		storia1 = ss1d.fine;
		
		GameObject s1dok = GameObject.Find("s1dialogo");
        startD ss1dok = s1dok.GetComponent<startD>();
		storia1ok = ss1dok.ok;
		
		
		GameObject s2d = GameObject.Find("s2dialogo");
        DialogueTrigger ss2d = s2d.GetComponent<DialogueTrigger>();
		storia2 = ss2d.fine;
		
		GameObject s2dok = GameObject.Find("s2dialogo");
        startD ss2dok = s2dok.GetComponent<startD>();
		storia2ok = ss2dok.ok;
		Debug.Log(nxt2);
		FollowPlayer=true;
		if(nxt1){
			if(storia1ok){
				FollowPlayer=false;
				transform.position = new Vector3(-75.67f, -2.25f, -10f);
			}
			
			if(storia1){
				
				storia1ok=false;
				FollowPlayer=true;
				nxt1=false;
			}
		}else{
			
	
			if(nxt2){
					
					if(storia2ok){
						FollowPlayer=false;
						transform.position = new Vector3(-75.67f, -2.25f, -10f);
					}
					
					if(storia2){
						storia2ok=false;
						FollowPlayer=true;
						nxt2=false;
					}
					
					if(!en0){
						FollowPlayer=false;
						transform.position = new Vector3(-55.92f, 7.81f, -10f);
					}
					
			}else{
				Debug.Log(nxt2);
					FollowPlayer=true;
					if(enT1){
						FollowPlayer=false;
						if(!en1){
							transform.position = new Vector3(-36.09f, 8.07f, -10f);
						}
					}
					if(enT2){
						FollowPlayer=false;
						if(!en2){
							transform.position = new Vector3(-35.81f, -2.38f, -10f);
						}
					}
				}
			}
		
		if(FollowPlayer){
				transform.position = new Vector3(player.position.x + offset.x, player.position.y + 0, offset.z);
		}
	}
	
	public void allabiblio(){
		nxt2=true;
	}
}
