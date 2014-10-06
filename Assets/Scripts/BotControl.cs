using UnityEngine;
using System.Collections;

public class BotControl : MonoBehaviour {

	enum Command{none, move, attack, defend};

	private Command currentCommand = Command.none;
	private Vector3 worldPos;

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
			RaycastHit hit;

			if(Physics.Raycast(testRay, out hit))
			{
				Debug.Log(hit);
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
}
