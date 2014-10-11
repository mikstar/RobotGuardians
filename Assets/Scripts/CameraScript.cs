using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public Transform camPos;
	private Vector3 camOffset;
	
	void Start()
	{
		camOffset= camPos.position - transform.position;
	}

	void Update () 
	{
		Vector3 testPos = ((camPos.position - transform.position)-camOffset) / 10;
		transform.Translate(testPos);
	}
}
