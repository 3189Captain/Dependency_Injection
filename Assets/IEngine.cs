using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEngine
{
	void StartEngine();
}

public class JetEngine : IEngine
{
	public void StartEngine()
	{
		ActivateJetStream();
		Debug.Log("Engine started");
	}

	private void ActivateJetStream()
	{
		Debug.Log("The jet stream is activated");
	}
}

public class NitroEngine : IEngine
{
	public void StartEngine()
	{
		OpenNitroValve();
		Debug.Log("Engine started");
	}

	private void OpenNitroValve()
	{
		Debug.Log("The nitro valve is open");
	}
}

public class RocketEngine : IEngine
{
	public void StartEngine()
	{
		Ignition();
		Debug.Log("Engine Started");
	}

	private void Ignition()
	{
		Debug.Log("Ignition in T minus 3, 2, 1...");
	}
}

public class SteamEngine : IEngine 
{
	public void StartEngine()
	{
		FillBoiler();
		Debug.Log("Engine started");
	}

	private void FillBoiler()
	{
		Debug.Log("Adding more coal to the boiler");
	}
}
