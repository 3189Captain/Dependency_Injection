using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDriver
{
	void Control(Bike bike);
}

public class HumanDriver : IDriver
{
	private Bike mBike;

	public void Control(Bike bike)
	{
		mBike = bike;
		Debug.Log("A human (player) will control the bike");
	}
}

public class AndroidDriver : IDriver
{
	private Bike mBike;

	public void Control(Bike bike)
	{
		mBike = bike;
		Debug.Log("This bike will be controlled by an AI");
	}
}

public class AlienDriver : IDriver
{
	private Bike mBike;

	public void Control(Bike bike)
	{
		mBike = bike;
		Debug.Log("This bike will be controlled by an Alien");
	}
}

public class SteampunkDriver : IDriver
{
	private Bike mBike;

	public void Control(Bike bike)
	{
		mBike = bike;
		Debug.Log("A Steampunk Chap will control this bike");
	}
}
