using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float velocity = 0.5f;
    [SerializeField] float paddleHeight = 1f;

    [SerializeField] KeyCode upKey = KeyCode.UpArrow;
    [SerializeField] KeyCode downKey = KeyCode.DownArrow;

    void Update()
    {
        if(Input.GetKey(upKey))
        {
            transform.position += velocity * Vector3.up * Time.deltaTime;
        } else if (Input.GetKey(downKey))
        {
            transform.position += velocity * Vector3.down * Time.deltaTime;
        }

        float cameraHeight = Camera.main.orthographicSize;

        //if(transform.position.y + (paddleHeight * 0.5f) >= cameraHeight)
        //{
        //    Vector3 positionAux = transform.position;
        //    positionAux.y = cameraHeight - (paddleHeight * 0.5f);
        //    transform.position = positionAux;
        //}
        //else if (transform.position.y - (paddleHeight * 0.5f) <= -cameraHeight)
        //{
        //    Vector3 positionAux = transform.position;
        //    positionAux.y = -cameraHeight + (paddleHeight * 0.5f);
        //    transform.position = positionAux;
        //}

        Vector3 positionAux = transform.position;
        positionAux.y = Mathf.Clamp(positionAux.y, -cameraHeight + (paddleHeight * 0.5f), cameraHeight - (paddleHeight * 0.5f));
        transform.position = positionAux;
    }
}
