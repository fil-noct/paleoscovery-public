using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class En2Trov : MonoBehaviour
{
	public UnityEvent attivo;
	public GameObject cam;
	public Animator anim;
    bool en;
	bool enT;
	
	void Start()
    {
    }

    void Update()
    {
		
		en=cam.GetComponent<CameraFollow>().en3;
		enT=cam.GetComponent<CameraFollow>().enT3;
		
		anim.SetBool("active", enT);
		
		if (Input.GetMouseButtonDown(0)){
            RaycastHit2D rayHit = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition));
			if(rayHit.transform.name == gameObject.name ){
				if(!en && enT){
					attivo.Invoke();
				}
			}
		}
    }
}
