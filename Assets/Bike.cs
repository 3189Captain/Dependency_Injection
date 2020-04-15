using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bike : MonoBehaviour
{
	private IEngine mEngine;
	private IDriver mDriver;

	public void SetEngine(IEngine engine)
	{
		mEngine = engine;
	}

	public void SetDriver(IDriver driver)
	{
		mDriver = driver;
	}

	public void StartEngine()
	{
		mEngine.StartEngine();
		mDriver.Control(this);
	}

	public void TurnLeft()
	{
		Debug.Log("LEFT TURN!!!!");
	}

	public void TurnRight()
	{
		Debug.Log("RIGHT TURN!!!!");
	}
}
