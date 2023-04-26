using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour
{
    [SerializeField] private List<int> listOfNumbers = new List<int>(32);

    [SerializeField] private List<Rigidbody2D> rb;

    private void Start()
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            int randomNumber = Random.Range(0, rb.Count);
            rb[randomNumber].AddForce(Vector2.right);
            Destroy(rb[randomNumber].gameObject, 1f);
            rb.RemoveAt(randomNumber);
        }
    }
}
