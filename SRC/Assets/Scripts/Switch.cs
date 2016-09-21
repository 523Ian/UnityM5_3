using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour 
{
	bool isOpen;
		
	void Start () 
	{
		isOpen = false;
	}



	public void SwitchDoor()
	{
		if(isOpen)
		{
			transform.position = new Vector3 (transform.position.x,transform.position.y-2.5f);
			isOpen  = false;
		} else
		{
			transform.position = new Vector3 (transform.position.x,transform.position.y+2.5f);
			isOpen = true;
		}
	}
}
