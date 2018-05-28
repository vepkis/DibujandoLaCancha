using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorMultiples : MonoBehaviour
{


	//	public ReceiveDedos datosDedos;
	public GameObject escAlta;
	public GameObject escMedia;
	public GameObject escBaja;
	public GameObject mano;

	// Use this for initialization
	void Start ()
	{
	}

	// Update is called once per frame
	void Update ()
	{
		
		condiciones ();
	
	}

	void condiciones ()
	{

	
		mano.GetComponent<CreaNota>().tecladoAcciona ();

		if (escAlta.GetComponent<DetectorDeAltura> ().dentro) {
			mano.GetComponent<CreaNota>().manoAcciona ();
			print("entra Alto");
		} else {
			//print ("NADA QUE VER");
		}
		if (escMedia.GetComponent<DetectorDeAltura> ().dentro) {
			mano.GetComponent<CreaNota>().manoAcciona ();
			print("entra Medio");
		} else {
			//print ("NADA QUE VER");
		}
		if (escBaja.GetComponent<DetectorDeAltura> ().dentro) {
			mano.GetComponent<CreaNota>().manoAcciona ();
			print("entra Bajo");
		} else {
			//print ("NADA QUE VER");
		}







	}
}
