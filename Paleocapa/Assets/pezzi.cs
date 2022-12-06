using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pezzi : MonoBehaviour
{
	public GameObject cam;
	public Text n;
	public int pz;
    void Update()
    {
        pz= cam.GetComponent<CameraFollow>().complt();
		Debug.Log(pz);
		
		n.text="";
		n.text+= pz;
		n.text+=" / 4";
	}
}
