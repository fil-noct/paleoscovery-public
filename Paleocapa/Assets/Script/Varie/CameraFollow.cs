
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
 
public class CameraFollow : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;
	public bool en1 = false;
	public bool en2 = false;
	public bool en3 = false;
	
	public int completi=0;
	
	bool en0 = false;
	public bool enT1 = false;
	public bool enT2 = false;
	public bool enT3 = false;
	
	bool gtEn1=false;
	bool gtEn2=false;
	bool gtEn3=false;
	
	public bool storia1 = false;
	public bool storia2 = false;
	public bool storia3 = false;
	public bool storia4 = false;
	public bool storia0 = false;
	
	public bool st0ini = false;
	public bool st1ini = false;
	public bool st2ini = false;
	public bool st3ini = false;
	public bool st4ini = false;
	
	
	public bool FollowPlayer=true;
	
    void Update()
    {
		GameObject eni1 = GameObject.Find("cryptex");
        controllo_parola chlet = eni1.GetComponent<controllo_parola>();
		en1 = chlet.comp;
		
		GameObject enigc1 = GameObject.Find("Enigma1_Cucciolo");
        enigmatoccato enit1 = enigc1.GetComponent<enigmatoccato>();
		enT1 = enit1.et;
		
		
		GameObject eni3 = GameObject.Find("cryptex1");
        cp2 chlet2 = eni3.GetComponent<cp2>();
		en3 = chlet2.comp;
		
		GameObject enigc3 = GameObject.Find("Enigma1_Cucciolo (1)");
        enigmatoccato enit3 = enigc3.GetComponent<enigmatoccato>();
		enT3 = enit3.et;
		
		GameObject eni2 = GameObject.Find("Buco");
        Enigma2Comp enicomp = eni2.GetComponent<Enigma2Comp>();
		en2 = enicomp.encomp;
		
		GameObject enigc2 = GameObject.Find("Enigma2_Cucciolo");
        enigmatoccato enit2 = enigc2.GetComponent<enigmatoccato>();
		enT2 = enit2.et;
		
		GameObject eni0 = GameObject.Find("sfondo biblioteca");
        Enigma0Comp eni0comp = eni0.GetComponent<Enigma0Comp>();
		en0 = eni0comp.comp;
		
		GameObject ppt1 = GameObject.Find("pt1");
        pt1 pt1s = ppt1.GetComponent<pt1>();
		storia1 = pt1s.fine;
		
		GameObject ppt2 = GameObject.Find("pt2");
        pt2 pt2s = ppt2.GetComponent<pt2>();
		storia2 = pt2s.fine;
		
		GameObject ppt3 = GameObject.Find("pt3");
        pt3 pt3s = ppt3.GetComponent<pt3>();
		storia3 = pt3s.fine;
		
		GameObject ppt4 = GameObject.Find("pt4");
        pt4 pt4s = ppt4.GetComponent<pt4>();
		storia4 = pt4s.fine;
		
		GameObject ppt0 = GameObject.Find("pt0");
        pt0 pt0s = ppt0.GetComponent<pt0>();
		storia0 = pt0s.fine;
		
		
		
		FollowPlayer=true;
		if(!storia1 && st1ini){
			
			GameObject.Find("pt1").GetComponent<Image>().enabled=true;
			GameObject.Find("pt1").GetComponent<pt1>().enabled=true;
			FollowPlayer=false;
		}else{
			GameObject.Find("pt1").GetComponent<Image>().enabled=false;
			GameObject.Find("pt1").GetComponent<pt1>().enabled=false;
		}
		
		if(!storia2 && st2ini){
			GameObject.Find("pt2").GetComponent<Image>().enabled=true;
			GameObject.Find("pt2").GetComponent<pt2>().enabled=true;
			FollowPlayer=false;
		}else{
			GameObject.Find("pt2").GetComponent<Image>().enabled=false;
			GameObject.Find("pt2").GetComponent<pt2>().enabled=false;
		}
		
		if(st0ini && !storia0){
			GameObject.Find("pt0").GetComponent<Image>().enabled=true;
			GameObject.Find("pt0").GetComponent<pt0>().enabled=true;
			FollowPlayer=false;
		}else{
			GameObject.Find("pt0").GetComponent<Image>().enabled=false;
			GameObject.Find("pt0").GetComponent<pt0>().enabled=false;
		}
		
		if(st4ini && !storia4){
			GameObject.Find("pt4").GetComponent<Image>().enabled=true;
			GameObject.Find("pt4").GetComponent<pt4>().enabled=true;
			FollowPlayer=false;
		}else{
			GameObject.Find("pt4").GetComponent<Image>().enabled=false;
			GameObject.Find("pt4").GetComponent<pt4>().enabled=false;
		}
		
		
		
		
		if(storia2 && !en0 && st2ini){
			FollowPlayer=false;
			transform.position = new Vector3(-56.18f, 7.807f, -10f);
		}else{
			
		}
		
		if(en0){
			pt3();
			FollowPlayer=true;
		}
		
		if(!storia3 && st3ini && en0){
			FollowPlayer=false;
			Debug.Log(storia3+ "" + st3ini + "" + en0);
			GameObject.Find("pt3").GetComponent<Image>().enabled=true;
			GameObject.Find("pt3").GetComponent<pt3>().enabled=true;
			
		}else{
			GameObject.Find("pt3").GetComponent<Image>().enabled=false;
			GameObject.Find("pt3").GetComponent<pt3>().enabled=false;
		}
		
		if(gtEn1){
			FollowPlayer=false;
		}
		if(gtEn2){
			FollowPlayer=false;
		}
		if(gtEn3){
			FollowPlayer=false;
		}
		
		
		
		
		Debug.Log(FollowPlayer);
		if(FollowPlayer){
				transform.position = new Vector3(player.position.x + offset.x, player.position.y + 0, offset.z);
		}
		
	
	}
	
	public void goToEn1(){
		gtEn1=true;
		FollowPlayer=false;
		transform.position = new Vector3(-36.09f, 8.07f, -10f);
	}
	
	public void goToEn2(){
		gtEn2=true;
		FollowPlayer=false;
		transform.position = new Vector3(-35.81f, -2.38f, -10f);
	}
	public void goToEn3(){
		gtEn3=true;
		FollowPlayer=false;
		transform.position = new Vector3(-35.82f, 15f, -10f);
	}
	public void bgoToEn1(){
		gtEn1=false;
		gtEn2=false;
		gtEn3=false;
		FollowPlayer=true;
	}
	public void bgoToEn2(){
		gtEn1=false;
		gtEn2=false;
		gtEn3=false;
		FollowPlayer=true;
	}
	public void bgoToEn3(){
		gtEn1=false;
		gtEn2=false;
		gtEn3=false;
		FollowPlayer=true;
	}
	
	public void fp(){
		FollowPlayer=true;
	}
	
	public void pt1(){
			st1ini=true;
	}
	public void pt2(){
			st2ini=true;
	}
	public void pt3(){
			st3ini=true;
	}
	public void pt4(){
			st4ini=true;
	}
	public void pt0(){
			st0ini=true;
	}
	
	public int complt(){
		completi=0;
		if(en0){
			completi++;
		}
		if(en1){
			completi++;
		}
		if(en2){
			completi++;
		}
		if(en3){
			completi++;
		}
		return completi;
	}
}
