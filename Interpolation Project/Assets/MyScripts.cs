using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScripts : MonoBehaviour
{
    Vector3 pos;
    Vector3 pos2;
    private float u;
    private float duration;
    void Start()
    {
        pos = transform.position;
        pos2 = new Vector3(3, 4, 5);
        duration = Time.time;
    }

   
    void Update()
    {
        u = duration - Time.time /2;
        Vector3 newPos = (1 - u) * pos + u * pos2;
        transform.position = newPos;
    }
}
