using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterNota : MonoBehaviour
{

	public GranNota gNota;
	public DrawLinePro dLPro;
	public GameObject player;
	private bool entradaTrig;
	private bool salidaTrig;

	// Use this for initialization
	void Start ()
	{
		
	}

	// Update is called once per frame
	void Update ()
	{
		activaLine ();
	}

	public void setEntrada ()
	{
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

	public void activaLine ()
	{
		if (salidaTrig == false) {
			setEntrada ();
		}
		setSalida ();
	}

}
