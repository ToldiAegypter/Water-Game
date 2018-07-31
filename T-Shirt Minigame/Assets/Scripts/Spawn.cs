using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
	 public Rigidbody2D NormalesTShirt;
     public Rigidbody2D AltesTShirt;  

	 // Use this for initialization
	 void Start ()
	 {
        nextActionTime = Time.time;

     }

	 void spawn ()
	 {
        if (Random.Range(0f, 1f) > 0.5f)
        {
            Instantiate(AltesTShirt, transform.position, Quaternion.AngleAxis(Random.Range(0f, 360f), Vector3.forward));
        }
        else
        {
            Instantiate(NormalesTShirt, transform.position, Quaternion.AngleAxis(Random.Range(0.0f, 360.0f), Vector3.forward));
        }
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