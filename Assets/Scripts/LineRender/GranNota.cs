using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GranNota : MonoBehaviour {

	public Triggersito trigA;
	public Triggersito trigB;


	void Start () {
	}
	
	void Update () {
		
	}

	public void setOrigenPrefab(Vector3 position_)
	{
//		OrigenPrefab.transform.position=position_;

	}

	public Triggersito getTrigA()
	{
		return this.trigA;
	}

	public Triggersito getTrigB()
	{
		return this.trigB;
	}



}
