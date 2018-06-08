using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CreaNota : MonoBehaviour
{


	public GameObject Pulgar;
	public GameObject NotaDo;
	public GameObject NotaRe;
	public GameObject NotaMi;
	public GameObject NotaFa;


	public ReceiveDedos recDedos;
	//	public float velBall = 100.0f;
	// Use this for initialization

	private bool presionaDO, presionaRE, presionaMI, presionaFA, presionaSI, presionaLA;

	void Start ()
	{
		presionaDO = false;
	}

	// Update is called once per frame
	public void Update ()
	{
	}


	public void tecladoAcciona ()
	{

		if (Input.GetKeyUp (KeyCode.Y)) {
			getPulgar ();
		}

		if (Input.GetKeyUp (KeyCode.U)) {
			getNotaDo ();
		}

		if (Input.GetKeyUp (KeyCode.I)) {
			getNotaRe ();
		}
		if (Input.GetKeyUp (KeyCode.O)) {
			getNotaMi ();
		}

		if (Input.GetKeyUp (KeyCode.P)) {
			getNotaFa ();
		}	

	}


	public void manoAcciona ()
	{


		/*
		if (Input.GetKeyUp(KeyCode.Y))
		{
			getPulgar ();
		}*/
		print (recDedos.getValoresDedos ());

		if (recDedos.getValoresDedos () [0] > 0) {
			if (recDedos.getValoresDedos () [1] > 0) {
				getNotaDo ();
				print ("LIFE____");
			} else if (recDedos.getValoresDedos () [0] == 0) {
				presionaDO = false;
			}

			if (recDedos.getValoresDedos () [2] > 0) {
				getNotaRe ();
			}
			if (recDedos.getValoresDedos () [3] > 0) {
				getNotaMi ();
			}

			if (recDedos.getValoresDedos () [4] > 0) {
				getNotaFa ();
			}
		}
	}


	public void getPulgar ()
	{
		GameObject instancia = Instantiate (Pulgar);
		instancia.transform.position = transform.position;

	}

	public void getNotaDo ()
	{
		presionaDO = true;
		if (presionaDO == true) {
			
			GameObject instancia = Instantiate (NotaDo);
			instancia.transform.position = transform.position;
			presionaDO = false;
		}
	}

	public void getNotaRe ()
	{
		GameObject instancia = Instantiate (NotaRe);
		instancia.transform.position = transform.position;
	}

	public void getNotaMi ()
	{
		GameObject instancia = Instantiate (NotaMi);
		instancia.transform.position = transform.position;
	}

	public void getNotaFa ()
	{
		GameObject instancia = Instantiate (NotaFa);
		instancia.transform.position = transform.position;
	}


	public void restricciones ()
	{

	}

}
