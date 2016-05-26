﻿using UnityEngine;
using System.Collections;

public class respawnPlayer : MonoBehaviour {

	private GameObject player;
	public float x = 0;
	public float y = 0;
	public float z = 0;
	public float deathHeight = -5;
	// Use this for initialization
	void Start () {
		player = this.gameObject;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (player.transform.position.y <= deathHeight) {
			Vector3 temp = new Vector3(x,y,z);
			player.transform.position = temp;
		}
	
	}
}
