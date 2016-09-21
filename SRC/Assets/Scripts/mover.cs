using UnityEngine;
using System.Collections;

public class mover : MonoBehaviour 
{
	Rigidbody2D _rb;

	bool _canJump;
	bool _walking;
	public bool _canEnter;
	bool _ladder;

	public float Velocidad = 6;
	public float JumpForce = 300;

	void Start () 
	{
		_rb  = GetComponent<Rigidbody2D>();

		_canJump = true;
		_walking = true;
		_canEnter = false;
		_ladder = false;
	}



	void Update () 
	{
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
		bool jump = Input.GetButtonDown("Jump"); 

		if(_walking){
			float vel = h * (Velocidad * Time.deltaTime);
			transform.Translate (vel, 0, 0);
			_rb.gravityScale = 1;
			_rb.isKinematic = false;
		
			if(jump && _canJump){
				_rb.AddForce(new Vector2(0,JumpForce));
				_canJump = false;
			}
		}
		if (_ladder){
			float vel = v*(Velocidad*Time.deltaTime);
			transform.Translate(0,vel,0);
			_rb.gravityScale = 0;
			_rb.isKinematic = true;
		}
		if(_walking && _canEnter && v>0)
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
}
