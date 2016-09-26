using UnityEngine;
using System.Collections;

public class Mover_pesonaje : MonoBehaviour 
{
	public float Velocidad = 3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float hor = Input.GetAxis("Horizontal");

		float vel = hor * (Velocidad * Time.deltaTime);

		transform.Translate (vel, 0, 0);
	}
}

