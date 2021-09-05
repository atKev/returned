using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MelittaChase : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    private Transform target;

    void Start()
    {
        target = null;
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if(other.tag == "Player")
        {
            target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        }
    }

    // Update is called once per frame
    void Update()
    {

        if(target != null)
        {
            if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            }
        }
    }
}
