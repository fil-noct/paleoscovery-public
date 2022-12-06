using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCielo : LastCheck
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Player.transform.position = new Vector2(lastpos.transform.position.x, lastpos.transform.position.y);
        }
    }
}
