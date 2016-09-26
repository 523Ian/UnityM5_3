using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour {

	public void Play()
	{
		SceneManager.LoadScene ("prueba");	
	}



	public void Exit()
	{
		Application.Quit ();
	}
}
