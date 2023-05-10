using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigonometry : MonoBehaviour
{
    public Transform bot;

    [Header("Ellipse")]
    public Vector2 startPos;
    public Vector2 amplitude;
    public Vector2 frequency;

    [Header("Degrees and Radians")]
    public float angle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Sine();
        //Cosine();
        //Tan();
        //Ellipse();
        //RotateInDeg();
        RotateInRad();
    }

    void Sine()
    {
        float xPos = startPos.x + Time.timeSinceLevelLoad;
        float yPos = startPos.y + amplitude.y * Mathf.Sin(frequency.y * Time.timeSinceLevelLoad);

        bot.position = new Vector2(xPos, yPos);
    }
    void Cosine()
    {
        float xPos = startPos.x + Time.timeSinceLevelLoad;
        float yPos = startPos.y + amplitude.y * Mathf.Cos(frequency.y * Time.timeSinceLevelLoad);

        bot.position = new Vector2(xPos, yPos);
    }

    void Tan()
    {
        float xPos = startPos.x + Time.timeSinceLevelLoad;
        float yPos = startPos.y + amplitude.y * Mathf.Tan(frequency.y * Time.timeSinceLevelLoad);

        bot.position = new Vector2(xPos, yPos);
    }

    void Ellipse()
    {
        float xPos = startPos.x + amplitude.x * Mathf.Sin(frequency.x * Time.timeSinceLevelLoad);
        float yPos = startPos.y + amplitude.y * Mathf.Cos(frequency.y * Time.timeSinceLevelLoad);

        bot.position = new Vector2(xPos, yPos);
    }

    void RotateInDeg()
    {
        bot.rotation = Quaternion.Euler(0f, 0f, angle);
    }

    void RotateInRad()
    {
        bot.rotation = Quaternion.Euler(0f, 0f, angle * Mathf.Deg2Rad);
    }
}
