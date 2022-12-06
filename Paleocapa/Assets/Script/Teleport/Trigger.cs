using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject Player;
    public Transform pos;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Player.transform.position = new Vector2(pos.transform.position.x, pos.transform.position.y);
        }
    }
}
