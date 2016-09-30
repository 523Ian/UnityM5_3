using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Pinchos : MonoBehaviour 
{
	public string Escena;
	void Start () 
	{
	
	}
	
	void Update () 
	{
	
	}

	void OnCollisionEnter2D(Collision2D c)
	{
		if (c.gameObject.tag == "Player")
			Debug.Log ("Pincho");
		SceneManager.LoadScene (Escena);
	}
}
