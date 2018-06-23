using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorSonoro : MonoBehaviour
{
	public int cant;
	public GameObject trigAPreFab;
	public GameObject trigBPreFab;
	public GameObject trigCPreFab;

	private bool[] activateTrigger;

	public GameObject[] sonTrig;
	//private AudioSource[] sonTrigAudio;

	private GameObject[] trigABC;

	void Awake ()
	{
		trigABC = new GameObject[cant];
		activateTrigger = new bool[cant];

		trigABC [0] = Instantiate (trigAPreFab, new Vector3 (-10, 2, 0), Quaternion.identity);
		trigABC [1] = Instantiate (trigBPreFab, new Vector3 (0, 2, 0), Quaternion.identity);
		trigABC [2] = Instantiate (trigCPreFab, new Vector3 (10, 2, 0), Quaternion.identity);

		for (int i = 0; i < sonTrig.Length; i++) {
	
			trigABC [i].GetComponent<TriggersitoSonoro> ().setSonidito (sonTrig [i]);

		}



	}

	void Start ()
	{

	}


	void Update ()
	{
		for (int i = 0; i < sonTrig.Length; i++) {
	
			trigABC [i].GetComponent<TriggersitoSonoro> ().disparaSonidito ();

/*
			if (trigABC [i].GetComponent<TriggersitoSonoro> ().getEntrada ()) {

				trigABC [i].GetComponent<TriggersitoSonoro> ().disparaSonidito ();
			}
			print (trigABC [i].GetComponent<TriggersitoSonoro> ().getEntrada ());
*/
		}

	}

	void setTrigger ()
	{
		if (Input.GetKey (KeyCode.P)) {
			for (int i = 0; i < sonTrig.Length; i++) {
				activateTrigger [i] = !activateTrigger [i];
				print ("aTrigger_Blaf----" + activateTrigger [i]);

			}
		}
	
	}
}
