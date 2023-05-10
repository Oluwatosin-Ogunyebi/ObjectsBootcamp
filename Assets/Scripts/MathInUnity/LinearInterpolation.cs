using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInterpolation : MonoBehaviour
{
    public float timeScale;

    public Transform pointA;
    public Transform pointB;
    public Transform pointC;
    public Transform bot1;
    public Transform bot2;
    public Transform bot3;

    [Range(0, 1f)]
    public float timer = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveBot1();
        MoveBot2();
        MoveBot3();

        timer += timeScale * Time.deltaTime;
        if (timer > 1)
        {
            timer = 0;
        }
    }

    void MoveBot1()
    {
        bot1.position = Vector2.Lerp(pointA.position, pointB.position, timer);
    }

    void MoveBot2()
    {
        bot2.position = Vector2.Lerp(pointB.position, pointC.position, timer);
    }

    void MoveBot3()
    {
        bot3.position = Vector2.Lerp(pointC.position, pointA.position, timer);
    }
}
