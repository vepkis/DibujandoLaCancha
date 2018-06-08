using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour {

	private LineRenderer lineRenderer;
	private float counter;
	private float dist;


	public Transform origen;
	public Transform destino;

	public float lineDrawSpeed = 0.8f;


	// Use this for initialization
	void Start () {
		lineRenderer = GetComponent<LineRenderer> ();
		lineRenderer.enabled = true;

	}

	// Update is called once per frame
	void Update () {
		dibuja ();

	}

	public void dibuja (){



			lineRenderer.SetPosition (0, origen.position);
			lineRenderer.SetPosition (1, destino.position);


		//	lineRenderer.SetWidth (.45f, .45f);

			dist = Vector3.Distance (origen.position, destino.position); 
		

		if (Input.GetKey (KeyCode.X)) {
			lineRenderer.enabled = false;
		}

		if (Input.GetKey (KeyCode.C)) {
			lineRenderer.enabled = true;
		}

	}





}
