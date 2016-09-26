using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class restart2 : MonoBehaviour 
{

	void Update () 
	{
		if(Input.GetKey(KeyCode.R)){
			 SceneManager.LoadScene("Level_2");
		}

	}
}
