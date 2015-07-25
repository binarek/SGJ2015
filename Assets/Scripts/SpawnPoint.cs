﻿using UnityEngine;
using System.Collections;

public class SpawnPoint : MonoBehaviour
{
	public Object spawnPrefab;
	public int spawnAmount;
	public int spawnCounter = 0;

	public float spawnRate = 5;
	private float timeToSpawn;


	void Start ()
	{
		timeToSpawn = spawnRate;
	}
	void Update ()
	{
		timeToSpawn -= Time.deltaTime;

		if (spawnCounter < spawnAmount && timeToSpawn < 0)
		{
			ChilCreate ();
			timeToSpawn = spawnRate;
		}
	}

	void ChilCreate ()
	{
		Vector3 offset = new Vector3 (Random.Range(1f, 5f), 0.5f, Random.Range(1f, 5f));
		GameObject civilian = (GameObject)Instantiate (spawnPrefab, transform.position + offset, Quaternion.identity);
		civilian.GetComponent<Civilian>().spawnPoint = this;
		spawnCounter++;
	}
}
