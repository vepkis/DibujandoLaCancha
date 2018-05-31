using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiveDedos : MonoBehaviour
{

	public OSC osc;
	private float dIndice, dCorazon, dAnular, dMenique, dPulgar, palma;
private float[] dedos = new float[5];

//	private int[] dedos = new int[5];


	// Use this for initialization
	public void Start ()
	{
		osc.SetAddressHandler ("/user1/guanteDer/Indice", OnReceiveIndice);
		osc.SetAddressHandler ("/user1/guanteDer/Corazon", OnReceiveCorazon);
		osc.SetAddressHandler ("/user1/guanteDer/Anular", OnReceiveAnular);
		osc.SetAddressHandler ("/user1/guanteDer/Menique", OnReceiveMenique);
		osc.SetAddressHandler ("/user1/guanteDer/Pulgar", OnReceivePulgar);
		osc.SetAddressHandler ("/user1/guanteDer/Palma", OnReceivePalma);


	}

	// Update is called once per frame
	void Update ()
	{
	}


	//-----Eventos mano

	private void OnReceiveIndice (OscMessage message)
	{
		this.dIndice = message.GetFloat (0);
	}

	private void OnReceiveCorazon (OscMessage message)
	{
		this.dCorazon = message.GetFloat (0);
	}

	private void OnReceiveAnular (OscMessage message)
	{
		this.dAnular = message.GetFloat (0);
	}

	private void OnReceiveMenique (OscMessage message)
	{
		this.dMenique = message.GetFloat (0);
	}

	private void OnReceivePulgar (OscMessage message)
	{
		this.dPulgar = message.GetFloat (0);
	}

	private void OnReceivePalma (OscMessage message)
	{
		this.palma = message.GetFloat (0);
	}

	public float [] getValoresDedos ()
	{
		dedos [0] = dPulgar;
		dedos [1] = dIndice;
		dedos [2] = dCorazon;
		dedos [3] = dAnular;
		dedos [4] = dMenique;
		return dedos;
	}

	public float getPalma ()
	{
		return palma;
	}
}
