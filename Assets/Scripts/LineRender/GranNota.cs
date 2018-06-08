using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GranNota : MonoBehaviour {

	public Triggersito trigA;
	public Triggersito trigB;


	// Use this for initialization
	void Start () {
		//trig = new Triggersito ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void setOrigenPrefab(Vector3 position_)
	{
//		OrigenPrefab.transform.position=position_;

	}

	public Triggersito getTrig()
	{
		return this.trigA;
	}

}
