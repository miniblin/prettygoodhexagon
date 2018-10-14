using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour {

	public Rigidbody2D rb;

	public float shrinkSpeed = 3f;

	// Use this for initialization
	// <summary>
	/// Awake is called when the script instance is being loaded.
	/// </summary>
	void Awake()
	{	
		transform.rotation= Quaternion.Euler(0,0,Random.Range(10f,360f));
		transform.localScale = Vector3.one *10f;
		Debug.Log(transform.rotation);
		Debug.Log(rb.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		transform.localScale -= Vector3.one * shrinkSpeed *Time.deltaTime;


		if (transform.localScale.x<=0.5f){
			Score.IncrementScore();
			Destroy(gameObject);
		}
	}
}
