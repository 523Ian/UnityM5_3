using UnityEngine;
using System.Collections;

public class Terminal : MonoBehaviour 
{
	public GameObject puerta;

	bool isInside = false;
	public Switch Switch;
	public GameObject ActionButton;


	void Start () 
	{
		ActionButton = GameObject.FindGameObjectWithTag ("BotonUsar");
	}
	
	void Update () 
	{
	} 	 

	void OnTriggerEnter2D(Collider2D c)
	{
		if (c.gameObject.tag == "Player") {
			isInside = true;
			ActionButton.SetActive (true);
			ActionButton.GetComponent<ActionButton> ().TerminalActual = this;
		}
	}
	void OnTriggerExit2D(Collider2D c)
	{
		if (c.gameObject.tag == "Player") {
			isInside = false;
			ActionButton.SetActive (false);
			ActionButton.GetComponent<ActionButton> ().TerminalActual = null;;
		}
	}

	public void SwitchPuerta()
	{
		if (isInside) {
			Switch.SwitchDoor ();
		}
	}
}
