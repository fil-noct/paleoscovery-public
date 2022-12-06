using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_lett : MonoBehaviour
{
	
	public Sprite A;
	public Sprite B;
	public Sprite C;
	public Sprite D;
	public Sprite E;
	public Sprite F;
	public Sprite G;
	public Sprite H;
	public Sprite I;
	public Sprite J;
	public Sprite K;
	public Sprite L;
	public Sprite M;
	public Sprite N;
	public Sprite O;
	public Sprite P;
	public Sprite Q;
	public Sprite R;
	public Sprite S;
	public Sprite T;
	public Sprite U;
	public Sprite V;
	public Sprite W;
	public Sprite X;
	public Sprite Y;
	public Sprite Z;
	
	private int intlettAtt;
	public char lettAtt;
    // Start is called before the first frame update
    void Start()
    {
		lettAtt='A';
		intlettAtt=65;
		this.gameObject.GetComponent<SpriteRenderer>().sprite = A;
    }

    // Update is called once per frame
    void Update()
    {
		switch(intlettAtt){
			case 65:	this.gameObject.GetComponent<SpriteRenderer>().sprite = A;
						lettAtt='A';
						break;
			case 66:	this.gameObject.GetComponent<SpriteRenderer>().sprite = B;
						lettAtt='B';
						break;
			case 67:	this.gameObject.GetComponent<SpriteRenderer>().sprite = C;
						lettAtt='C';
						break;
			case 68:	this.gameObject.GetComponent<SpriteRenderer>().sprite = D;
						lettAtt='D';
						break;
			case 69:	this.gameObject.GetComponent<SpriteRenderer>().sprite = E;
						lettAtt='E';
						break;
			case 70:	this.gameObject.GetComponent<SpriteRenderer>().sprite = F;
						lettAtt='F';
						break;
			case 71:	this.gameObject.GetComponent<SpriteRenderer>().sprite = G;
						lettAtt='G';
						break;
			case 72:	this.gameObject.GetComponent<SpriteRenderer>().sprite = H;
						lettAtt='H';
						break;
			case 73:	this.gameObject.GetComponent<SpriteRenderer>().sprite = I;
						lettAtt='I';
						break;
			case 74:	this.gameObject.GetComponent<SpriteRenderer>().sprite = J;
						lettAtt='J';
						break;
			case 75:	this.gameObject.GetComponent<SpriteRenderer>().sprite = K;
						lettAtt='K';
						break;
			case 76:	this.gameObject.GetComponent<SpriteRenderer>().sprite = L;
						lettAtt='L';
						break;
			case 77:	this.gameObject.GetComponent<SpriteRenderer>().sprite = M;
						lettAtt='M';
						break;
			case 78:	this.gameObject.GetComponent<SpriteRenderer>().sprite = N;
						lettAtt='N';
						break;
			case 79:	this.gameObject.GetComponent<SpriteRenderer>().sprite = O;
						lettAtt='O';
						break;
			case 80:	this.gameObject.GetComponent<SpriteRenderer>().sprite = P;
						lettAtt='P';
						break;
			case 81:	this.gameObject.GetComponent<SpriteRenderer>().sprite = Q;
						lettAtt='Q';
						break;
			case 82:	this.gameObject.GetComponent<SpriteRenderer>().sprite = R;
						lettAtt='R';
						break;
			case 83:	this.gameObject.GetComponent<SpriteRenderer>().sprite = S;
						lettAtt='S';
						break;
			case 84:	this.gameObject.GetComponent<SpriteRenderer>().sprite = T;
						lettAtt='T';
						break;
			case 85:	this.gameObject.GetComponent<SpriteRenderer>().sprite = U;
						lettAtt='U';
						break;
			case 86:	this.gameObject.GetComponent<SpriteRenderer>().sprite = V;
						lettAtt='V';
						break;
			case 87:	this.gameObject.GetComponent<SpriteRenderer>().sprite = W;
						lettAtt='W';
						break;
			case 88:	this.gameObject.GetComponent<SpriteRenderer>().sprite = X;
						lettAtt='X';
						break;
			case 89:	this.gameObject.GetComponent<SpriteRenderer>().sprite = Y;
						lettAtt='Y';
						break;
			case 90:	this.gameObject.GetComponent<SpriteRenderer>().sprite = Z;
						lettAtt='Z';
						break;
		}
    }
	
	public void cliccato_giu(){
		intlettAtt++;
		if(intlettAtt == 91){
			intlettAtt=65;
			lettAtt='A';
		}
	}
	
	public void cliccato_su(){
		intlettAtt--;
		if(intlettAtt == 64){
			intlettAtt=90;
			lettAtt='Z';
		}
	}
}
