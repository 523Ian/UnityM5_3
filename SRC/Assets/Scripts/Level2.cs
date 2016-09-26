using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour 
{
	void OnTriggerEnter2D(Collider2D c)
	{
		if (c.tag == "Player") {
			SceneManager.LoadScene ("Level_2");
		}
	}
}
