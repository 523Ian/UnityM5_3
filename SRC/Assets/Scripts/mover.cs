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
<<<<<<< HEAD
	int _dirx;
	int _diry;
=======
	bool _derecha;
	bool _up;
>>>>>>> master

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
<<<<<<< HEAD

		_dirx = 0;
		_diry = 0;
=======
		_derecha = false;
		_up = true;
>>>>>>> master
	}



	void Update () 
	{
<<<<<<< HEAD
		float velx = _dirx * Velocidad * Time.deltaTime;
		float vely = _diry * Velocidad * Time.deltaTime;
		_walking = velx != 0;

		if(_walking){
			transform.Translate (velx, 0, 0);
=======
		
		float v = Input.GetAxis("Vertical");
		float h = Input.GetAxis ("Horizontal");
		bool jump = Input.GetButtonDown("Jump");
		float vel = v * (Velocidad * Time.deltaTime);

		if(_walking){

			float velh = h*(Velocidad * Time.deltaTime);
			transform.Translate (velh, 0, 0);
>>>>>>> master

			_rb.gravityScale = 1;
			_rb.isKinematic = false;
		}
<<<<<<< HEAD

		if (_ladder && !_walking) {	// esta en escalera			
			transform.Translate (0, vely, 0);
		}
	}



	void OnCollisionEnter2D(Collision2D coll)
	{
		if(coll.collider.tag == "Platform"){
			Debug.Log ("Colision");
			_canJump = true;
		}
	}



	public void OnRightDown()
	{
		_dirx = 1;
		Debug.Log ("sss");
	}

	public void OnLeftDown()
	{
		_dirx = -1;
	}

	public void OnRightUp()
	{
		_dirx = 0;
	}

	public void OnLeftUp()
	{
		_dirx = 0;
	}



	public void OnUpUp()
	{
		_diry = 1;

		if (CanEnter) {
=======
		if (_ladder){
			if (_up) {
				
				transform.Translate (0, vel, 0);
				_rb.gravityScale = 0;
				_rb.isKinematic = true;
			}
		}
		if(_walking && CanEnter && v>0)
		{
>>>>>>> master
			_walking = false;
			_ladder = true;
			_rb.gravityScale = 0;
			_rb.isKinematic = true;
		} else {
			SalirEscalera ();
		}
	}

	public void OnUpDown()
	{
		_diry = 0;
	}



	public void Jump()
	{
		if(_canJump){
			_rb.AddForce(new Vector2(0,JumpForce));
			_canJump = false;
		}
	}


<<<<<<< HEAD
	public void SalirEscalera() {
		_walking = true;
		_ladder = false;
		_rb.gravityScale = 1;
		_rb.isKinematic = false;
	}
}
=======
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
>>>>>>> master
