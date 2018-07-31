using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container1 : MonoBehaviour
{


     public Counter counter;

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "AltesTShirt")
        {
            counter.MehrPunkte(1);
            Destroy(other.gameObject);
        }

        if (other.tag == "NormalesTShirt")
        {
            counter.MehrPunkte(-2);
            Destroy(other.gameObject);
        }




    }


}
