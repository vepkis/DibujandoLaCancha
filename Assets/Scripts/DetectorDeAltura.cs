using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorDeAltura : MonoBehaviour 
{

//	public Transform Spawnpoint;
//	public GameObject Prefab;
	public bool dentro= false;


	void update ()
	{
		//print (dentro);
	}


	void OnTriggerEnter ()

	{
		dentro = true;
	}
	void OnTriggerExit()
	{
		dentro = false;
		print ("DAMNNNNN!!!");
	}
	public bool getDentro()
	{
		return dentro;
	}


}