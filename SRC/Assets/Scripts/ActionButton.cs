﻿using UnityEngine;
using System.Collections;

public class ActionButton : MonoBehaviour 
{
	public Terminal TerminalActual;

	void Start () {
		StartCoroutine (Desactivar ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator Desactivar()
	{
		yield return new WaitForSeconds (0.3f);
		gameObject.SetActive (false);
	}


	public void ActivarTerminal()
	{
		if (TerminalActual != null) {
			TerminalActual.SwitchPuerta ();
		}
	}
}
