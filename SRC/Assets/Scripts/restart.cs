using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour 
{
<<<<<<< HEAD
	public string Escena;
	void Update () 
	{
		if(Input.GetKey(KeyCode.R)){
			SceneManager.LoadScene(Escena);
=======

	void Update () 
	{
		if(Input.GetKey(KeyCode.R)){
			SceneManager.LoadScene("prueba");
>>>>>>> master
		}
	}
}
