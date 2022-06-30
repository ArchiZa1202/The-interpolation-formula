using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZenosFollower : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject poi; // Point Of Interest - точка интереса
    public float u = 0.1f;
    public Vector3 p0, p1, p01;
    
    void FixedUpdate()
    {
        // Получить позицию этого игрового объекта и poi
        p0 = this.transform.position;
        p1 = poi.transform.position;
        // Выполнить интерполяцию между ними
        p01 = (1 - u) * p0 + u * p1;
        // Переместить этот игровой объект в новую позицию
        this.transform.position = p01;
    }
}
