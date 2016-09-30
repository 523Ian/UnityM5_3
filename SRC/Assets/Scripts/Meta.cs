using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Meta : MonoBehaviour 
{
<<<<<<< HEAD
	public string NameScene;
	void OnTriggerEnter2D(Collider2D c)
	{
		if (c.tag == "Player") {
			SceneManager.LoadScene (NameScene);
=======
	void OnTriggerEnter2D(Collider2D c)
	{
		if (c.tag == "Player") {
			SceneManager.LoadScene ("Menu");
>>>>>>> master
		}
	}
}
