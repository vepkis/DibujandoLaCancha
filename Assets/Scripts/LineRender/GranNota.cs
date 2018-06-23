using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GranNota : MonoBehaviour
{

	public Triggersito trigA;
	private Vector3 posTrigA;

	public Triggersito trigB;
	private Vector3 posTrigB;
/*
	public GranNota()
	{
		setPosTrigAB ();

	}

	public GranNota(float posAX_, float posAY_, float posAZ_, float posBX_,  float posBY_, float posBZ_)
	{
		setPosTrigAB (posAX_, posAY_, posAZ_, posBX_, posBY_, posBZ_);
	}
*/
	public void setPosTrigAB ()
	{
		posTrigA = new Vector3 (Random.Range (-10, 0), 1.7f,Random.Range (10,12));
		posTrigB = new Vector3 (Random.Range (0, 10), 1.7f, -1);
		trigA.transform.localPosition = posTrigA;
		trigB.transform.localPosition = posTrigB;
	}
	public void setPosTrigAB (float posAX_, float posAY_, float posAZ_, float posBX_,  float posBY_, float posBZ_)
	{
		posTrigA = new Vector3 (posAX_,posAY_,posAZ_);
		posTrigB = new Vector3 (posBX_, posBY_, posBZ_);
		trigA.transform.localPosition = posTrigA;
		trigB.transform.localPosition = posTrigB;
	}

	/*
	void Awake()
	{
		setPosTrigAB ();

	}
*/
	void Start ()
	{
		setPosTrigAB ();
	}

	public Triggersito getTrigA ()
	{
		return this.trigA;
	}

	public Triggersito getTrigB ()
	{
		return this.trigB;
	}



}
