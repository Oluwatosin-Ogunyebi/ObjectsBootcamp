using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalarsAndVectors : MonoBehaviour
{
    public Vector2 position;
    public Vector2 velocity;
    public Vector3 direction;

    public float rotation;

    public float scalar;

    public Transform bot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Position
        bot.position = position;

        //Scaled Position
        //bot.position = scalar * position;

        //Velocity
        //if (Input.GetKeyDown(KeyCode.V))
        //{
        //    bot.GetComponent<Rigidbody>().velocity = velocity;
        //}

        //if (Input.GetKeyDown(KeyCode.V))
        //{
        //    bot.GetComponent<Rigidbody>().velocity = scalar * velocity;
        //}

        //Direction
        //bot.rotation = Quaternion.Euler(direction);

        bot.rotation = Quaternion.Euler(0, 0, rotation);


        //Velocity towards direction
        //if (Input.GetKey(KeyCode.V))
        //{
        //    bot.Translate(velocity);
        //}

        //Translate with scalar and vector

        //if (Input.GetKey(KeyCode.V))
        //{
        //    //bot.Translate(Vector2.right * velocity);
        //    //bot.Translate(Vector2.right * scalar);
        //}

        //if (Input.GetKey(KeyCode.Mouse0))
        //{
        //    rotation += scalar * Time.deltaTime;
        //}

        //if (Input.GetKey(KeyCode.Mouse1))
        //{
        //    rotation -= scalar * Time.deltaTime;
        //}

        if (Input.GetKey(KeyCode.M))
        {
            Debug.Log($"Distance from 0 {position.magnitude}");
            Debug.Log($"Amount of Velocity {velocity.magnitude}");
        }
    }
}
