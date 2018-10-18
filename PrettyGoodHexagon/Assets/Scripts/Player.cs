using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;
public class Player : MonoBehaviour {


	public float moveSpeed = 400f;

	float movement =0f;

	// Use this for initialization
	void Start () {
		 Screen.sleepTimeout = SleepTimeout.NeverSleep;
	}
	
	// Update is called once per frame
	void Update () {
		movement = CrossPlatformInputManager.GetAxis("Horizontal");	
	}

	/// <summary>
	/// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
	/// </summary>
	void FixedUpdate()
	{
		transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
	}

	/// <summary>
	/// Sent when another object enters a trigger collider attached to this
	/// object (2D physics only).
	/// </summary>
	/// <param name="other">The other Collider2D involved in this collision.</param>
	void OnTriggerEnter2D(Collider2D other)
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
