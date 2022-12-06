using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class su : MonoBehaviour
{
	public UnityEvent cliccatos;

    void Update()
    {
		if (Input.GetMouseButton(0))
        {
            RaycastHit2D rayHit = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition));
			if(rayHit.transform.name == gameObject.name){
				cliccatos.Invoke();
			}
		}
		
    }
}
