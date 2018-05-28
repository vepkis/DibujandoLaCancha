using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectorEscena : MonoBehaviour
{
	public SelectorEscenasOSC selOSC;

	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space)) {

			seleccionaEscena ();

		}
		for (int i = 0; i < selOSC.getEscenas ().Length; i++) {
			if (selOSC.getEscenas () [i] == 1.0f) {
				SceneManager.LoadScene (i);
			}
		}


		/*		if (Input.GetKeyDown(keyCode: "1"))
		{
				seleccionaEscena ();

		}
*/
	}

	void seleccionaEscena ()
	{
		int actual = SceneManager.GetActiveScene ().buildIndex;

		if ((actual + 1) < 4) {

			SceneManager.LoadScene (actual + 1);

		}

		if (actual == 3) {
			SceneManager.LoadScene (0);
		}


	}

}
