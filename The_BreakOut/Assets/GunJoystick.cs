using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using CodeMonkey.Utils;
using System;

public class GunJoystick : MonoBehaviour
{

    public Joystick joystick;
    public GameObject Object;
    Vector2 GameobjectRotation;
    private float GameobjectRotation2;
    private float GameobjectRotation3;

    public bool FacingRight = true;


    void Awake()
    {
     //   aimTransform = transform.Find("Aim");
     //   aimAnimator = aimTransform.GetComponent<Animator>();
    }





    void Update()
    {
		HandleShooting();

		//Gets the input from the jostick
		GameobjectRotation = new Vector2(joystick.Horizontal, joystick.Vertical);
		GameobjectRotation3 = GameobjectRotation.x;

		if (FacingRight)
		{
			
			//Rotates the object if the player is facing right
			GameobjectRotation2 = GameobjectRotation.x + GameobjectRotation.y * 90;
			Object.transform.rotation = Quaternion.Euler(0f, 0f, GameobjectRotation2);
		//	HandleShooting();
		}
		else
		{
			//Rotates the object if the player is facing left
			GameobjectRotation2 = GameobjectRotation.x + GameobjectRotation.y * -90;
			Object.transform.rotation = Quaternion.Euler(0f, 180f, -GameobjectRotation2);
		}
		if (GameobjectRotation3 < 0 && FacingRight)
		{
			// Executes the void: Flip()
			Flip();
		}
		else if (GameobjectRotation3 > 0 && !FacingRight)
		{
			// Executes the void: Flip()
			Flip();
		}
	}

	//private void HandleShooting()
	//{
		//throw new NotImplementedException();
	//}

	private void Flip()
	{
		// Flips the player.
		FacingRight = !FacingRight;

		transform.Rotate(0, 180, 0);
	}
	private void HandleShooting()
	{
		
	}

}






