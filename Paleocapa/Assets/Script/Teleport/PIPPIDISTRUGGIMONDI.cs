using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PIPPIDISTRUGGIMONDI : MonoBehaviour
{
    public GameObject Player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Player.transform.position = new Vector2(-17.38f, -17.51f);
        }
    }
}
