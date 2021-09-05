using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public AudioClip Tür;
    public void OnTriggerEnter2D (Collider2D collider)
    {
        GetComponent<AudioSource>().PlayOneShot(Tür);
    }
}
