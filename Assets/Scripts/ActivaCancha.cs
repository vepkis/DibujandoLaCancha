using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivaCancha : MonoBehaviour {

	public bool canchaActiva= false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		canchaActiva = true;
	}


	public bool getCanchaActiva(){
	
		return canchaActiva;
	}
}
