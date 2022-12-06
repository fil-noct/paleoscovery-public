using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Hideinventory : MonoBehaviour
{
	public UnityEvent apri;
	public UnityEvent chiudi;
	public bool open=false;
	public Animator anim;
	
	
    void Start()
    {
		chiudi.Invoke();
    }

    void Update()
    {
		anim.SetBool("open", open);
		
		
		if (Input.GetMouseButtonDown(0)){
            RaycastHit2D rayHit = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition));
			if(rayHit.transform.name == gameObject.name ){
				if(open==false){
					open=true;
					apri.Invoke();
				}else{
					open=false;
					chiudi.Invoke();
				}
				
				
			}
		}
		
    }
}
