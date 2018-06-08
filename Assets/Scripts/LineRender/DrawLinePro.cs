using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLinePro : MonoBehaviour {


	private LineRenderer lineRenderer;
	private float dist;


	private Transform origen;
	private Transform destino;

	private float lineDrawSpeed = 0.8f;


	private bool activaEntrada;
	private bool activaSalida;


	void Start () {
		lineRenderer = GetComponent<LineRenderer> ();

	}

	void Update () {
		dibuja ();

	}

	public void setOrigen(Transform origen_)
	{
		origen=origen_;
	}

	public void setDestino( Transform destino_)
	{
		destino=destino_;
	}

	public void dibuja (){


		//if (Input.GetKey (KeyCode.F)) {
	//	lineRenderer.SetPosition (0, origen.position);
	//	lineRenderer.SetPosition (1, destino.position);


		//	lineRenderer.SetWidth (.45f, .45f);

	//	dist = Vector3.Distance (origen.position, destino.position); 

		if (activaEntrada== true)
		{
			lineRenderer.SetPosition (0, origen.position);
		}

	}

	public void setActivaEntrada (bool activaEntrada_)
	{
		this.activaEntrada = activaEntrada_;
	}

	public void setActivaSalida (bool activaSalida_)
	{
		this.activaSalida = activaSalida_;
	}


}
