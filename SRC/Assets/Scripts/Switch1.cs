using UnityEngine;
using System.Collections;

public class Switch1 : MonoBehaviour 
{
	public bool isOpen = false;
		

	public void SwitchPlatform()
	{
		if(isOpen)
		{
			transform.position = new Vector3 (transform.position.x-2.5f,transform.position.y);
			isOpen  = false;
		} else
		{
			transform.position = new Vector3 (transform.position.x+2.5f,transform.position.y);
			isOpen = true;
		}
	}
}
