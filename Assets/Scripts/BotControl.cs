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
				if(hitInfo.collider.name == "Enemy")
				{
					destination = hitInfo.collider.transform.position;
					currentCommand = Command.attack;
				}

				else
				{
					destination = hitInfo.point;
					currentCommand = Command.move;
				}
			}
		}

		if(currentCommand == Command.move)
		{
			MoveTo(destination);
		}

		if(currentCommand == Command.attack)
		{
			if(Vector3.Distance(transform.position, destination) <=  3.0f)
			{
				Vector3 tempAngles = new Vector3(0,Mathf.Rad2Deg * Mathf.Atan2((destination.x - transform.position.x) , (destination.z - transform.position.z)),0);
				transform.eulerAngles = tempAngles;
				Debug.Log("Attacking enemy");
			}

			else
			{
				MoveTo(destination);
			}

		}

		if(currentCommand == Command.defend)
		{
			

		}
		if(currentCommand == Command.none)
		{
			

		}
	}

	void MoveTo(Vector3 target)
	{
		rigidbody.velocity = Vector3.zero;
		Vector3 tempAngles = new Vector3(0,Mathf.Rad2Deg * Mathf.Atan2((destination.x - transform.position.x) , (destination.z - transform.position.z)),0);
		transform.eulerAngles = tempAngles;
		rigidbody.AddRelativeForce(Vector3.forward * 100 * speed);
		
		if(Vector3.Distance(transform.position, target) <=  1.0f)
		{
			rigidbody.velocity = Vector3.zero;
			currentCommand = Command.none;
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