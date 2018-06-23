using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceivePositionII : MonoBehaviour
{


	public OSC osc;
	public Vector3 valorVector;

	public float velocidad = 10.0F;
	//Velocidad de movimiento
	//	public float rotationSpeed = 100.0F; //Velocidad de rotación

	// Use this for initialization
	public void Start ()
	{
//		osc.SetAddressHandler ("/user1/guanteDer/PosX", OnReceiveX);
//		osc.SetAddressHandler ("/user1/guanteDer/PosY", OnReceiveY);
//	osc.SetAddressHandler ("/user1/guanteDer/PosZ", OnReceiveZ);
			
		//	osc.SetAddressHandler ("/user1/guanteDer/PosX", OnReceiveY);
		osc.SetAddressHandler ("/user1/guanteDer/PosY", OnReceiveZ);//Mueve en --Z--
		osc.SetAddressHandler ("/user1/guanteDer/PosZ", OnReceiveX);//Mueve en --X--

	
	}

	// Update is called once per frame
	void Update ()
	{

	}


	public float map (float x, float in_min, float in_max, float out_min, float out_max)
	{
		return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
	}

	//Recordar que esto hay que modificarlo!__K
	void OnReceiveX (OscMessage message)
	{
		float x = message.GetFloat (0);
		print ("valorX_______" + x);

		//valorVector = transform.position;

		valorVector.x = map (x, -50, 50, -15, 15);

		transform.localPosition = valorVector;
		print (valorVector.x);
	
	}

	void OnReceiveY (OscMessage message)
	{
		float y = message.GetFloat (0);
		print ("valorY_______" + y);

		valorVector.y = map (y, 90, -90, -10, 10);

		transform.localPosition = valorVector;
		print (valorVector.y);

	}


	void OnReceiveZ (OscMessage message)
	{
		float z = message.GetFloat (0);
		print ("valorZ_______" + z);

		valorVector.z = map (z, -70, 70, -25, 25);

		transform.localPosition = valorVector;
		print (valorVector.z);

	}


	/*	void OnReceiveX (OscMessage message)
	{
		float x = message.GetFloat (0);

		valorVector = transform.position;

		valorVector.x = x;

		transform.position = valorVector;

	}
*/
	/*	void OnReceiveY (OscMessage message)
	{
		float y = message.GetFloat (0);

		valorVector = transform.position;

		valorVector.y = y;

		transform.position = valorVector;
	}

	void OnReceiveZ (OscMessage message)
	{
		float z = message.GetFloat (0);

		valorVector= transform.position;

		valorVector.z = z;

		transform.position = valorVector;
	}
	*/

	public Vector3 getValorVector ()
	{

		return valorVector;
	}


}
