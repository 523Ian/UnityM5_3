using UnityEngine;
using System.Collections;

public class Escalera : MonoBehaviour 
{

	void Start () 
	{
	
	}
	
	void Update () 
	{
	
	}

	void OnTriggerEnter2D(Collider2D otro)
	{
		if(otro.tag == "Player"){
			mover m = otro.GetComponent<mover>();
			m._canEnter = true;
		}
	}
	void OnTriggerExit2D(Collider2D otro)
	{
		if(otro.tag == "Player"){
			mover m = otro.GetComponent<mover>();
			m._canEnter = false;
		}
	}
}
