using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Meta : MonoBehaviour 
{
	void OnTriggerEnter2D(Collider2D c)
	{
		if (c.tag == "Player") {
			SceneManager.LoadScene ("Menu");
		}
	}
}
