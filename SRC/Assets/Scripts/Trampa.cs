using UnityEngine;
using System.Collections;

public class Trampa : MonoBehaviour {

	public GameObject Trap;

	void Start () 
	{
		StartCoroutine (Desactivar ());
	}

	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D c)
	{
		if (c.gameObject.tag == "Player") {
			Trap.SetActive (true);
		}
	}

	IEnumerator Desactivar()
	{
		yield return new WaitForSeconds (0.3f);
		Trap.SetActive (false);
	}
}
