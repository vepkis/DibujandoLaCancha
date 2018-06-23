using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DibujaLinea : MonoBehaviour
{
	public GameObject lineaPrefab;
	private LineRenderer lRender;
	public Vector3 origen = new Vector3 (0,0,0);
	public Vector3 destino= new Vector3 (0,0,0);

	public int valorPru = 13;
	public bool activaEntrada = false;
	public bool activaSalida = false;

	void Start ()
	{

		/*Descomentá la siguiente linea si querés usar esta clase directamente*/
		lRender = Instantiate (lineaPrefab.GetComponent<LineRenderer> ());
	
		origen = new Vector3 ();
		destino = new Vector3 ();
	}
	
	// Update is called once per frame
	void Update ()
	{
	dibuja ();
//		setDestino();
		print(this.activaEntrada);
	}

	public void setDestino ()
	{
		lRender.SetPosition (0, origen);
		lRender.SetPosition (1, destino);

	}

	public void setOrigen (Vector3 origen_)
	{
		this.origen = origen_;
	}

	public void setDestino (Vector3 destino_)
	{
		this.destino = destino_;
	}

	public Vector3 getOrigen ()
	{
		return origen;
	}


	public Vector3 getDestino ()
	{
		return destino;
	}

	public LineRenderer getLRender ()
	{
		return lRender;
	}

	public void setLRender (LineRenderer lr_)
	{
		this.lRender = lr_;
	}


	public void dibuja ()
	{

		if (activaEntrada == true) {
			setDestino ();
		}

		if (activaSalida == true) {
			lRender.SetPosition (1, destino);
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
