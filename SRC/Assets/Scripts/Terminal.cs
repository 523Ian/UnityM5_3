using UnityEngine;
using System.Collections;

public class Terminal : MonoBehaviour 
{
	public GameObject puerta;

	bool isInside = false;
	public Switch Switch;
	void Start () 
	{
		
	}
	
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.E) && isInside)
		{
			Switch.SwitchDoor();
		}
	} 	 

	void OnTriggerEnter2D(Collider2D c)
	{
		if (c.gameObject.tag == "Player") 
			isInside = true;
	}
	void OnTriggerExit2D(Collider2D c)
	{
		if (c.gameObject.tag == "Player")
			isInside = false;
	}
}
