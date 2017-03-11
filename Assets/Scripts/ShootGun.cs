using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootGun : MonoBehaviour {

	public GameObject shot;
	public float fireRate;
	public Transform shotSpawn;

	private float nextFire;

	void Update () {
		if(Input.GetButton("Fire1") && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			GameObject clone;
			Quaternion rotationAmount = Quaternion.Euler(0, 0, -90);
			clone = Instantiate(shot, shotSpawn.position, shotSpawn.rotation*rotationAmount) as GameObject;
		}
	}
}
