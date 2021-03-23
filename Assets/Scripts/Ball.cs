using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float velocity = 5f;
    bool launched = false;
    [SerializeField] float launchTimer = 2f;
    float launchCounter = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //if(Random.value < 0.5f)
        //{
        //    GetComponent<Rigidbody2D>().velocity = velocity * Vector2.right;
        //} else
        //{
        //    GetComponent<Rigidbody2D>().velocity = velocity * Vector2.left;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        if(!launched)
        {
            launchCounter += Time.deltaTime;
            if(launchCounter >= launchTimer)
            {
                GetComponent<Rigidbody2D>().velocity = velocity * Random.onUnitSphere;
                launched = true;
            }
        }
    }
}
