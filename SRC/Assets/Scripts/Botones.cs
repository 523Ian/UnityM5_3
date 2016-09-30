using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

<<<<<<< HEAD
public class Botones : MonoBehaviour 
{

	public void Play(string Escena)
	{
		SceneManager.LoadScene (Escena);	
=======
public class Botones : MonoBehaviour {

	public void Play()
	{
		SceneManager.LoadScene ("prueba");	
>>>>>>> master
	}



	public void Exit()
	{
		Application.Quit ();
	}
<<<<<<< HEAD



	public void Reset(string Escena)
	{
		SceneManager.LoadScene (Escena);
	}
=======
>>>>>>> master
}
