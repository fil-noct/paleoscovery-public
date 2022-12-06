using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distEnigma2 : MonoBehaviour
{
	bool dist;
	void Update(){
		GameObject cam = GameObject.Find("Main Camera");
		CameraFollow camv = cam.GetComponent<CameraFollow>();
		dist = camv.en2;
		if(dist){
			Destroy(gameObject);
		}
	}
}

