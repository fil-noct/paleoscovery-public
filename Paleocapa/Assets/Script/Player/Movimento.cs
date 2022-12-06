using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    public CharacterController2D controller;
	public Animator animator;
    public float runSpeed = 40f;

    float horizontalMove = 0f;

    bool jump = false;
    void Update()
	
    {
		GameObject cam = GameObject.Find("Main Camera");
        CameraFollow sc = cam.GetComponent<CameraFollow>();
		bool fp = sc.FollowPlayer;
		
		if(fp){
			runSpeed=40f;
			horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
			
			animator.SetFloat("AnimSpeed", Mathf.Abs(horizontalMove));
			
			if (Input.GetButtonDown("Jump"))
			{
				jump = true;
				animator.SetBool("AnimJump", true);
			}
		}else{
			runSpeed=0;
		}
    }
	
	public void onLanding()
	{
		animator.SetBool("AnimJump", false);
	}

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}