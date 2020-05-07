using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 1.62f;

    void Update()
    {
        var vertical = Input.GetAxis("Vertical");
        var horizontal = Input.GetAxis("Horizontal");
        
        var translation = vertical * speed * Time.deltaTime;
        var rotation = horizontal * rotationSpeed * Time.deltaTime;

        transform.position = RotateMath.Translate(new Coordinate(transform.position),
            new Coordinate(transform.up), 
            new Coordinate(0,translation,0)).GetAsVector3();
        transform.up = RotateMath.Rotate(new Coordinate(transform.up), -rotation * Mathf.Deg2Rad).GetAsVector3();
    }
}
