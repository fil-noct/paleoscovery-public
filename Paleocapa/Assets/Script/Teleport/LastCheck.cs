using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastCheck : MonoBehaviour
{
    protected Transform lastpos;
    [SerializeField]
    public GameObject Player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            lastpos = this.gameObject.transform;
            Debug.Log("preso" + lastpos);
        }
    }
}