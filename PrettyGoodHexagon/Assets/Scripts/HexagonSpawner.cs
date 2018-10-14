using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexagonSpawner : MonoBehaviour {

	public GameObject hexagon;

	public float spawnRate = 1f;

	private float nextTimeToSpawn=0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Time.time>= nextTimeToSpawn){
			Instantiate(hexagon, Vector3.zero, Quaternion.identity);
			nextTimeToSpawn = Time.time + 1/spawnRate;
		}
		
	}
}
