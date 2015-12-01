﻿using UnityEngine;
using System.Collections;

public class Done_WeaponController : MonoBehaviour
{
	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	public float delay;

	void Start ()
	{
		InvokeRepeating("Fire", delay, fireRate);
	}

/*
	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			//store Player position
			player = col.gameObject;
			InvokeRepeating("Fire", delay, fireRate);
		}
	}

	void OnTriggerExit(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			//remove player loc
			player = null;
			CancelInvoke("Shoot");
		}
	}
*/


	void Fire ()
	{
		Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
		GetComponent<AudioSource>().Play();
	}
}
