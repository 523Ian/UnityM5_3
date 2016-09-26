using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour 
{

	void Update () 
	{
		if(Input.GetKey(KeyCode.R)){
			SceneManager.LoadScene("prueba");
		}
	}
}
