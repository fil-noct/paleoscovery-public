using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overworld : MonoBehaviour
{
    public GameObject Player;
    public Transform pos;
    string message = "";
    private GUIStyle guiStyle = new GUIStyle();
    // Start is called before the first frame update
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            message = "PREMI W PER TORNARE SU";
            if (Input.GetKeyDown("w"))
            {
                Player.transform.position = new Vector2(pos.transform.position.x, pos.transform.position.y);
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
        guiStyle.fontSize = 30;
        GUI.Label(new Rect(400, 400, 0, 10), message, guiStyle);
    }
}
