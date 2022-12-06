using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HEY : MonoBehaviour
{
    public GameObject Player;
    private GUIStyle guiStyle = new GUIStyle();
    string message = "";
    // Start is called before the first frame update
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            message = "NON È CHE SE VEDI UNA GROTTA DEVI ENTRARCI PER FORZA";
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
        guiStyle.fontSize = 40;
        GUI.Label(new Rect(50, 500, 0, 10), message, guiStyle);
    }
}
