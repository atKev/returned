using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour
{
    public Transform warpTarget;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("An object Collided.");
        if(other. tag == "Player" || other.tag == "Character")
        {
            other.gameObject.transform.position = warpTarget.position;
        }
        if(other.tag == "Player")
        {
            Camera.main.transform.position = warpTarget.position;
        }
    }
}
