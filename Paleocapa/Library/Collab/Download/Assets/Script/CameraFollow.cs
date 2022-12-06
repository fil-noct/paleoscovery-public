
using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;
	bool ok= false;
    void Update()
    {
		GameObject lett = GameObject.Find("cryptex");
        controllo_parola chlet = lett.GetComponent<controllo_parola>();
		ok = chlet.comp;
		if(ok){
			transform.position = new Vector3(player.position.x + offset.x, player.position.y + 0, offset.z); // Camera follows the player with specified offset position
		}
	}
}
