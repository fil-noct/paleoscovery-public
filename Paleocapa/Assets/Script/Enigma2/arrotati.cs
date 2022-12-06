using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrotati : MonoBehaviour
{
    float rotz;
	//transform.localRotation = Quaternion.Euler(0, 0, 0);
	
    public void giradx(){
        rotz -= 0.3f * Time.deltaTime * 165;
        transform.localRotation = Quaternion.Euler(0, 0, rotz);
    }
	public void girasx(){
        rotz += 0.3f * Time.deltaTime * 165;
        transform.localRotation = Quaternion.Euler(0, 0, rotz);
    }
}
