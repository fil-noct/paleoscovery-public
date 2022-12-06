using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;

public class pt2 : MonoBehaviour
{
	public Image im;
    public Sprite pt1_1;
	public Sprite pt1_2;
	int img=1;
	public bool fine=false;
	
    void Update(){
		chg_img();
		if(Input.GetKeyDown("space")){
			img++;
		}
    }
	
	void chg_img(){
		switch(img){
			case 1: im.sprite = pt1_1;
					break;
			case 2: im.sprite = pt1_2;
					break;
			
			case 3:	fine=true;
					break;
		}
	}
	
}
