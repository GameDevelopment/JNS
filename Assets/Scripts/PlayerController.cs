using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	public float
		gravity = 20,
		speed = 8,
		jumpPower = 8;
	
	private Vector3 motion = Vector3.zero;
	private float velocity;
	private bool lookRight = true;
	private bool dblJump = true;
	private CharacterController characterController;
	private ShootLeftOrRight shoot;
	
	public bool IsGrounded {
		get { return characterController.isGrounded; }
	}
	public bool ButtonShoot {
		get { return Input.GetButtonDown ("Fire1"); }
	}
	public bool ButtonJump {
		get { return Input.GetButtonDown ("Jump"); }
	}

	// Use this for initialization
	void Start () 
	{
		characterController = GetComponent<CharacterController>();
		shoot = GetComponent<ShootLeftOrRight>();
	}
	
	void Update()
	{
		motion.x = Input.GetAxis("Horizontal") * speed;
		motion.y -= gravity * Time.deltaTime;
		
		if (motion.x > 0) 
		{
			lookRight = true;
		}
		else if (motion.x < 0)
		{
			lookRight = false;
		}
		
		if (IsGrounded) 
		{
			motion.y = -1;
			dblJump = true;
			if (ButtonJump) Jump ();
		}
		else
		{
			if (dblJump) {
				if (ButtonJump) 
				{
					Jump ();
					dblJump = false;
				}
			}
		}
		
		if (ButtonShoot) {
			shoot.Shoot(lookRight);
		}
		
		characterController.Move(motion * Time.deltaTime);
	}
	
	void Jump()
	{
		motion.y = jumpPower;
	}
	
	public void ResetJump()
	{
		dblJump = true;
	}
}
