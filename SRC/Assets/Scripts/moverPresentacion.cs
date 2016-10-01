using UnityEngine;
using System.Collections;

public class moverPresentacion : MonoBehaviour 
{

	public float Velo;
	public float BackVel;

	public GameObject num;
	public GameObject dot;
	public GameObject Lvl;
	public GameObject back;

	void Update () 
	{
		#if UNITY_EDITOR_WIN

		if(Input.GetKey(KeyCode.Space)){
			num.transform.Translate (Velo,0,0);
			dot.transform.Translate(0,Velo,0);
			Lvl.transform.Translate(0,-Velo,0);
			back.transform.Translate(-BackVel,0,0);

		} 
		#endif

		#if UNITY_ANDROID
		if (Input.touchCount > 0) {
			num.transform.Translate (Velo,0,0);
			dot.transform.Translate(0,Velo,0);
			Lvl.transform.Translate(0,-Velo,0);
			back.transform.Translate(-BackVel,0,0);
		}
		#endif
	}
}
