using UnityEngine;
using System.Collections;

public class mover : MonoBehaviour 
{
	Rigidbody2D _rb;

	public bool Derecha {
		get{ return _derecha;}
		set{ _derecha = value;}
	}

	bool _canJump;
	bool _walking;
	bool _ladder;
	bool _derecha;
	bool _up;

	public bool CanEnter;
	public float Velocidad = 6;
	public float JumpForce = 300;

	void Start () 
	{
		_rb  = GetComponent<Rigidbody2D>();

		_canJump = true;
		_walking = true;
		CanEnter = false;
		_ladder = false;
		_derecha = false;
		_up = true;
	}



	void Update () 
	{
		
		float v = Input.GetAxis("Vertical");
		float h = Input.GetAxis ("Horizontal");
		bool jump = Input.GetButtonDown("Jump");
		float vel = v * (Velocidad * Time.deltaTime);

		if(_walking){

			float velh = h*(Velocidad * Time.deltaTime);
			transform.Translate (velh, 0, 0);

			_rb.gravityScale = 1;
			_rb.isKinematic = false;
		
			if(jump && _canJump){
				_rb.AddForce(new Vector2(0,JumpForce));
				_canJump = false;
			}
		}
		if (_ladder){
			if (_up) {
				
				transform.Translate (0, vel, 0);
				_rb.gravityScale = 0;
				_rb.isKinematic = true;
			}
		}
		if(_walking && CanEnter && v>0)
		{
			_walking = false;
			_ladder = true;
		} else {
			_walking = true;
			_ladder = false;
		}

	}



	void OnCollisionEnter2D(Collision2D coll)
	{
		if(coll.collider.tag == "Platform"){
			Debug.Log ("Colision");
			_canJump = true;
		}
	}


//	public void Right()
//	{
//		_derecha = true;
//	}
//	public void Left()
//	{
//		_left = true; 
//	}
//	public void Up()
//	{
//		_up = true;
//	}
//	public void Jump()
//	{
//		if(_canJump){
//			_rb.AddForce(new Vector2(0,JumpForce));
//			_canJump = false;
//		}
//	}
//	public void RightUp ()
//	{
//		_derecha = false; 
//	}
//	public void LeftUp()
//	{
//		_left = false; 
//	}
//	public void UpRelease()
//	{
//		_up = false;
//	}
}