using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piattaforme : MonoBehaviour
{
    public GameObject Player;
    public GameObject plat;
    float timeLeft = 30.0f;
    bool oraDiCadere = false;
    bool inizioCount = false;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (oraDiCadere == true)
            {
                Rigidbody newRigidbody = plat.AddComponent<Rigidbody>();
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            inizioCount = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            timeLeft = 30.0f;
            oraDiCadere = false;
            inizioCount = false;
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if(inizioCount == true)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                oraDiCadere = true;
            }
        }
    }
}
