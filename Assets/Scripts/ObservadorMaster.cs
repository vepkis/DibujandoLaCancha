using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObservadorMaster : MonoBehaviour {
	public ActivaCancha activaCan;
	public GameObject preFabricado;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (activaCan.getCanchaActiva ()) {
			preFabricado.SetActive (true);
		} else {
			print ("Nada de nada...");
		}
	}
}
