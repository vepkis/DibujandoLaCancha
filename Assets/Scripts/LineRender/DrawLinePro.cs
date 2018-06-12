using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLinePro : MonoBehaviour {


	private LineRenderer lineRenderer;
	private float dist;


	public Vector3 origen;
	public Vector3 destino;

	private float lineDrawSpeed = 0.8f;


	private bool activaEntrada;
	private bool activaSalida;


	void Start () {
		lineRenderer = GetComponent<LineRenderer> ();

	}

	void Update () {
		dibuja ();

	}

	public void setOrigen(Vector3 origen_)
	{
		origen=origen_;
		print (origen);
	}

	public void setDestino( Vector3 destino_)
	{
		destino=destino_;
		print (origen);

	}

	public void dibuja (){


		//if (Input.GetKey (KeyCode.F)) {
	//	lineRenderer.SetPosition (0, origen.position);
	//	lineRenderer.SetPosition (1, destino.position);


		//	lineRenderer.SetWidth (.45f, .45f);

	//	dist = Vector3.Distance (origen.position, destino.position); 

		if (activaEntrada== true)
		{
			lineRenderer.SetPosition (0, origen);
			lineRenderer.SetPosition (1, destino);

		}

		if (activaSalida== true)
		{
			lineRenderer.SetPosition (1, destino);
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
