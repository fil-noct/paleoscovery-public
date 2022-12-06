using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class giu : MonoBehaviour
{
	public UnityEvent cliccatog;
    void Start()
    {
    }

    void Update()
    {
		
		if (Input.GetMouseButtonDown(0)){
            RaycastHit2D rayHit = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition));
			if(rayHit.transform.name == gameObject.name ){
				cliccatog.Invoke();
			}
		}
		
    }
}
