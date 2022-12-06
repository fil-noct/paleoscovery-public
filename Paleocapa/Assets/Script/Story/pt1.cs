using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;

public class pt1 : MonoBehaviour
{
	public Image im;
    public Sprite pt1_1;
	public Sprite pt1_2;
	public Sprite pt1_3;
	public Sprite pt1_4;
	public Sprite pt1_5;
	public Sprite pt1_6;
	public Sprite pt1_7;
	public Sprite pt1_8;
	public Sprite pt1_9;
	public Sprite pt1_10;
	public Sprite pt1_11;
	public Sprite pt1_12;
	public Sprite pt1_13;
	int img=4;
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
			case 3: im.sprite = pt1_3;
					break;
			case 4: im.sprite = pt1_4;
					break;
			case 5: im.sprite = pt1_5;
					break;
			case 6: im.sprite = pt1_6;
					break;
			case 7: im.sprite = pt1_7;
					break;
			case 8: im.sprite = pt1_8;
					break;	
			case 9: im.sprite = pt1_9;
					break;
			case 10: im.sprite = pt1_10;
					break;
			case 11: im.sprite = pt1_11;
					break;
			case 12: im.sprite = pt1_12;
					break;
			case 13: im.sprite = pt1_13;
					break;
			case 14: fine=true;
					break;
		}
	}
	
}
