using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distEnigma1 : MonoBehaviour
{
	bool dist;
	void Update(){
		GameObject cam = GameObject.Find("Main Camera");
		CameraFollow camv = cam.GetComponent<CameraFollow>();
		dist = camv.en1;
		if(dist){
			Destroy(gameObject);
		}
	}
}

