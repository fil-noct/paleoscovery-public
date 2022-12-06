using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pt4 : MonoBehaviour
{
    public Image im;
    public Sprite pt1_1;
	public Sprite pt1_2;
	public Sprite pt1_3;
	
	public Sprite pt2_1;
	public Sprite pt2_2;
	public Sprite pt2_3;
	
	public Sprite pt3_1;
	public Sprite pt3_2;
	public Sprite pt3_3;
	
	public Sprite pt0_1;
	public Sprite pt0_2;
	
	public int img=1;
	public bool fine=false;
	
    void Update(){
		chg_img();
		if(Input.GetKeyDown("space")){
			img++;
		}
    }
	
	void chg_img(){
		
		int comp = GameObject.Find("Main Camera").GetComponent<CameraFollow>().completi;
		
		switch(img){
			case 1: if(comp==1){
						im.sprite = pt1_1;
					}
					if(comp==2 || comp == 3){
						im.sprite = pt2_1;
					}
					if(comp==4){
						im.sprite = pt3_1;
					}
					
					break;
					
			case 2: if(comp==1){
						im.sprite = pt1_2;
					}
					if(comp ==2 || comp == 3){
						im.sprite = pt2_2;
					}
					if(comp==4){
						im.sprite = pt3_2;
					}
					
					break;
			
			case 3: im.sprite = pt0_1;
					break;
			case 4: im.sprite = pt0_2;
					break;
					
			case 5: if(comp==1){
						im.sprite = pt1_3;
					}
					if(comp==2 || comp == 3){
						im.sprite = pt2_3;
					}
					if(comp==4){
						im.sprite = pt3_3;
					}
					
					break;
			
			case 6:	fine=true;
					break;
		}
	}
}
