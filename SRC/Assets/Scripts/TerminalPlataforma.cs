using UnityEngine;
using System.Collections;

public class TerminalPlataforma : MonoBehaviour 
{
	public GameObject puerta;

	bool isInside = false;
	public Switch1 Switch;
	void Start () 
	{

	}

	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.E) && isInside)
		{
			Switch.SwitchPlatform();
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