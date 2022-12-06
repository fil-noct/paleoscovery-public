 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.Video;
 using UnityEngine.SceneManagement;
 
public class videofin : MonoBehaviour
{
	public bool fine=false;
	public VideoPlayer VideoPlayer;
    // Update is called once per frame
    void Start()
    {
         VideoPlayer.loopPointReached += finito;
    }
	void finito(VideoPlayer vp){
		fine=true;
		Destroy(VideoPlayer);
	}
	
}
