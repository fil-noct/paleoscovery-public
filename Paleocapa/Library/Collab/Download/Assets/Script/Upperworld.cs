using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upperworld : MonoBehaviour
{
    public GameObject Player;
    string message = "";
    private GUIStyle guiStyle = new GUIStyle();
    // Start is called before the first frame update
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            message = "PREMI W PER ANDARE SU";
            if (Input.GetKeyDown("w"))
            {
                Player.transform.position = new Vector2(5.08f, 10.03f);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            message = "";
        }
    }
    private void OnGUI()
    {
        guiStyle.fontSize = 20;
        GUI.Label(new Rect(400, 400, 0, 10), message, guiStyle);
    }
}
