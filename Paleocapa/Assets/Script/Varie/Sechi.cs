using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sechi : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("SECHI È DIVENTATO GAY");
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("SECHI È ANCORA GAY");
    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log("SECHI NON È PIÙ GAY");
    }
}
