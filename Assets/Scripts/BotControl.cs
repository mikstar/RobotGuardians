using UnityEngine;
using System.Collections;

public class BotControl : MonoBehaviour {

	enum Command{none, move, attack, defend};

	private Command currentCommand = Command.none;

	private Vector3 destination;
	public float speed = 1.0f;


	public void giveMoveCommand()
	{

	}

	public void giveAttackCommand()
	{

	}

	public void giveDefendCommand()
	{

	}

	private void Update()
	{
		if(Input.GetMouseButtonDown(0))
		{
			Ray testRay = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hitInfo;

			if (Physics.Raycast(testRay, out hitInfo))
			{
				destination = hitInfo.point;
			
				currentCommand = Command.move;

			}
		}

		if(currentCommand == Command.move)
		{
		//	rigidbody.velocity = Vector3.zero;
			Vector3 tempAngles = new Vector3(0,Mathf.Rad2Deg * Mathf.Atan2((destination.x - transform.position.x) , (destination.z - transform.position.z)),0);
			transform.eulerAngles = tempAngles;
			rigidbody.AddRelativeForce(Vector3.forward * 500);

			if(Vector3.Distance(transform.position, destination) <=  0.5f)
			{
				rigidbody.velocity = new Vector3(0,0,0);
				currentCommand = Command.none;
			}

		}

		if(currentCommand == Command.attack)
		{
			

		}

		if(currentCommand == Command.defend)
		{
			

		}
		if(currentCommand == Command.none)
		{
			
			Debug.Log("Nothing is habbening");
		}


	}
//		if(Input.touchCount > 0)
//		{
//			Ray testRay = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
//			RaycastHit hitInfo;
//
//			if (Physics.Raycast(testRay, out hitInfo))
//			{
//			
//			}
//		}
}