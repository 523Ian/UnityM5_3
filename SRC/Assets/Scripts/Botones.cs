using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour 
{

	public void Play(string Escena)
	{
		SceneManager.LoadScene (Escena);	
	}



	public void Exit()
	{
		Application.Quit ();
	}



	public void Reset(string Escena)
	{
		SceneManager.LoadScene (Escena);
	}
}
