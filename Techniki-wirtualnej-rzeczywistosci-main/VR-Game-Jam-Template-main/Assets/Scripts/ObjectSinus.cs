using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSinus : MonoBehaviour
{

    public float speed = 1.0f; // Szybkoœæ

    void Update(){

        float newZ = Mathf.Sin(Time.time * speed) * 10;
        transform.position = new Vector3(transform.position.x, transform.position.y, newZ);
    }
}
