using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorEscenasOSC : MonoBehaviour
{

	public OSC osc;
	private float esc0, esc1, esc2, esc3;
	private float[] escena = new float[4];
	// Use this for initialization
	public void Start ()
	{
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


	public float [] getEscenas ()
	{
		escena [0] = esc0;
		escena [1] = esc1;
		escena [2] = esc2;
		escena [3] = esc3;
		return escena;
	}



}
