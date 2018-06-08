using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterNota : MonoBehaviour {

	public GranNota gNota;
	public DrawLinePro dLPro;

	private bool entradaTrig;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		activaLine ();
	}

	public void setEntrada()
	{
		this.entradaTrig = gNota.getTrig().getEntrada();
	//	print (entradaTrig);
		if (gNota.getTrig().getEntrada())
		{
		//	dLPro.setOrigen (gNota.getTrig().GetComponent<Triggersito>());
			dLPro.setActivaEntrada (true);	

		}
	
	}
public void activaLine()
	{
		setEntrada ();
	}

}
