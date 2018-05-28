using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiveDedos : MonoBehaviour
{

	public OSC osc;
	private int dIndice, dCorazon, dAnular, dMenique, dPulgar, palma;
	private float esc0, esc1, esc2, esc3;
	//private float[] dedos = new float[5];

	private int[] dedos = new int[5];


	// Use this for initialization
	public void Start ()
	{
		osc.SetAddressHandler ("/user1/guanteDer/Indice", OnReceiveIndice);
		osc.SetAddressHandler ("/user1/guanteDer/Corazon", OnReceiveCorazon);
		osc.SetAddressHandler ("/user1/guanteDer/Anular", OnReceiveAnular);
		osc.SetAddressHandler ("/user1/guanteDer/Menique", OnReceiveMenique);
		osc.SetAddressHandler ("/user1/guanteDer/Pulgar", OnReceivePulgar);
		osc.SetAddressHandler ("/user1/guanteDer/Palma", OnReceivePalma);

		osc.SetAddressHandler ("/escenaOsc/0", OnReceiveEscena0);
		osc.SetAddressHandler ("/escenaOsc/1", OnReceiveEscena1);
		osc.SetAddressHandler ("/escenaOsc/2", OnReceiveEscena2);
		osc.SetAddressHandler ("/escenaOsc/3", OnReceiveEscena3);

	}

	// Update is called once per frame
	void Update ()
	{
	}

	private void OnReceiveEscena0 (OscMessage message)
	{
		this.esc0 = message.GetFloat (0);
	}

	private void OnReceiveEscena1 (OscMessage message)
	{
		this.esc1 = message.GetFloat (0);
	}

	private void OnReceiveEscena2 (OscMessage message)
	{
		this.esc2 = message.GetFloat (0);
	}

	private void OnReceiveEscena3 (OscMessage message)
	{
		this.esc3 = message.GetFloat (0);
	}

	//-----Eventos mano

	private void OnReceiveIndice (OscMessage message)
	{
		this.dIndice = message.GetInt (0);
	}

	private void OnReceiveCorazon (OscMessage message)
	{
		this.dCorazon = message.GetInt (0);
	}

	private void OnReceiveAnular (OscMessage message)
	{
		this.dAnular = message.GetInt (0);
	}

	private void OnReceiveMenique (OscMessage message)
	{
		this.dMenique = message.GetInt (0);
	}

	private void OnReceivePulgar (OscMessage message)
	{
		this.dPulgar = message.GetInt (0);
	}

	private void OnReceivePalma (OscMessage message)
	{
		this.palma = message.GetInt (0);
	}

	public int [] getValoresDedos ()
	{
		dedos [0] = dPulgar;
		dedos [1] = dIndice;
		dedos [2] = dCorazon;
		dedos [3] = dAnular;
		dedos [4] = dMenique;
		return dedos;
	}

	public int getPalma ()
	{
		return palma;
	}
}
