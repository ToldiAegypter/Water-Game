using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
	 public Rigidbody2D NormalesTShirt;
     public Rigidbody2D AltesTShirt;  

     public Transform SpawnPoint1;
     public Transform SpawnPoint2;
     public Transform SpawnPoint3;

	 // Use this for initialization
	 void Start ()
	 {
        nextActionTime = Time.time;

     }

	 void spawn ()
	 {
        Instantiate(
        	whatToSpawn(), 
        	whereToSpawn(), 
        	Quaternion.AngleAxis (0f, Vector3.forward)
        );
	 }

	 Rigidbody2D whatToSpawn() {
	 	if (Random.Range(0f, 1f) > 0.5f) {
	 		return AltesTShirt;
	 	} else {
	 		return NormalesTShirt;
	 	}
	 }

	 Vector3 whereToSpawn() {
	 	float r = Random.Range(0f, 1f);
	 	if (r < 0.33) {
	 		return SpawnPoint1.position;
	 	}
	 	if (r > 0.67) {
	 		return SpawnPoint3.position;
	 	}
	 	return SpawnPoint2.position;
	 }

	 private float nextActionTime = 0.0f;
	 public float secondsBetweenSpawn = 3f;

	 void Update ()
	 {
		  if ( Time.time > nextActionTime ) {
				nextActionTime += secondsBetweenSpawn;

				spawn();
		  }
	 }

}