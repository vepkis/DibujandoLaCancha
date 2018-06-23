using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterNota : MonoBehaviour
{

public GranNota [] gNota;
	public DrawLinePro dLPro;
	public GameObject player;
//	public GranNota gNota;

	//public GameObject gNotaPrefab;
	//private GameObject gNotaInstantiate;

	private bool entradaTrig;
	private bool salidaTrig;


	// Use this for initialization
	void Start ()
	{
//		gNotaInstantiate = (GameObject)Instantiate (gNotaPrefab, posRandom (), Quaternion.identity);
//		gNota = gNotaInstantiate.AddComponent<GranNota> ();

		/*
		for (int i = 0; i < gNota.Length; i++) {
			Instantiate (gNota[i], posRandom (), Quaternion.identity);
		}*/
	}
	// Update is called once per frame
	void Update ()
	{
		activaLine ();
	}


	public Vector3 posRandom ()
	{
		Vector3 vecty = new Vector3 (Random.Range (-10, 0), 1.7f, Random.Range (10, 12));
		return vecty;
	}
/*
	public void setEntrada ()
	{
//		for (int i = 0; i < gNota.Length; i++) {
		if (gNota.getTrigA ().getEntrada () && entradaTrig == false) {
			this.entradaTrig = gNota.getTrigA ().getEntrada ();

			dLPro.setOrigen (gNota.getTrigA ().transform.position);

			dLPro.setActivaEntrada (true);
		}
		dLPro.setDestino (player.transform.position);


	}

	public void setSalida ()
	{
		if (gNota.getTrigB ().getEntrada () && entradaTrig == true) {
			this.salidaTrig = gNota.getTrigB ().getEntrada ();

			dLPro.setDestino (gNota.getTrigB ().transform.position);
			dLPro.setActivaSalida (true);

		}


	}
*/

		public void setEntrada ()
	{
		for (int i = 0; i < gNota.Length; i++) {
			if (gNota [i].getTrigA ().getEntrada () && entradaTrig == false) {
				this.entradaTrig = gNota [i].getTrigA ().getEntrada ();

				dLPro.setOrigen (gNota [i].getTrigA ().transform.position);

				dLPro.setActivaEntrada (true);
			}
			dLPro.setDestino (player.transform.position);

		}

	}

	public void setSalida ()
	{
		for (int i = 0; i < gNota.Length; i++) {
			if (gNota [i].getTrigB ().getEntrada () && entradaTrig == true) {
				this.salidaTrig = gNota [i].getTrigB ().getEntrada ();

				dLPro.setDestino (gNota [i].getTrigB ().transform.position);
				dLPro.setActivaSalida (true);

			}
		}
			
	}


	public void activaLine ()
	{
		if (salidaTrig == false) {
			setEntrada ();
		}
		setSalida ();
	}

}
