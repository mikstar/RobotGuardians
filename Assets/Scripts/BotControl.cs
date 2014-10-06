using UnityEngine;
using System.Collections;

public class BotControl : MonoBehaviour {

	enum Command{none, move, attack, defend};

	private Command currentCommand = Command.none;

	public void giveMoveCommand()
	{
		if(currentCommand != Command.move)
		{

		}
	}

	public void giveAttackCommand()
	{

	}

	public void giveDefendCommand()
	{

	}
}
