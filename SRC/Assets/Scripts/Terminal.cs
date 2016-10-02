using UnityEngine;
using System.Collections;

public class Terminal : MonoBehaviour 
{
	SpriteRenderer _rend;

	public GameObject puerta;
	bool isInside = false;
	bool isActive;
	public Switch Switch;
	public GameObject ActionButton;

	public Sprite Activo;
	public Sprite Inactivo;


	void Start () 
	{
		_rend = GetComponent<SpriteRenderer> ();

		ActionButton = GameObject.FindGameObjectWithTag ("BotonUsar");
		isActive = false;
	}
	
	void Update () 
	{
		if (isActive) {
			_rend.sprite = Activo;
		} else {
			_rend.sprite = Inactivo;
		}

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
			if (isActive) {
				isActive = false;
			} else {
				isActive = true;
			}
		}
	}
}
