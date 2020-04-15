using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pattern.DependencyInjection
{
	public class Client : MonoBehaviour
	{
		public Bike mPlayerBike;
		public Bike mAndroidBike;
		public Bike mAlienBike;
		public Bike mSteampunkBike;

		private void Awake()
		{
			IEngine jetEngine = new JetEngine();
			IDriver humanDriver = new HumanDriver();

			mPlayerBike.SetEngine(jetEngine);
			mPlayerBike.SetDriver(humanDriver);
			mPlayerBike.StartEngine();

			IEngine nitroEngine = new NitroEngine();
			IDriver androidDriver = new AndroidDriver();

			mAndroidBike.SetEngine(nitroEngine);
			mAndroidBike.SetDriver(androidDriver);
			mAndroidBike.StartEngine();

			IEngine rocketEngine = new RocketEngine();
			IDriver alienDriver = new AlienDriver();

			mAlienBike.SetEngine(rocketEngine);
			mAlienBike.SetDriver(alienDriver);
			mAlienBike.StartEngine();

			IEngine steamEngine = new SteamEngine();
			IDriver steampunkDriver = new SteampunkDriver();

			mSteampunkBike.SetEngine(steamEngine);
			mSteampunkBike.SetDriver(steampunkDriver);
			mSteampunkBike.StartEngine();
		}

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.A))
			{
				mPlayerBike.TurnLeft();
			}

			if (Input.GetKeyDown(KeyCode.D))
			{
				mPlayerBike.TurnRight();
			}
		}

		private void OnGUI()
		{
			GUI.color = Color.black;
			GUI.Label(new Rect(10, 10, 500, 20), "Press A to turn LEFT and D to turn RIGHT");
			GUI.Label(new Rect(10, 30, 500, 20), "Output displayed in console");
		}
	}
}
