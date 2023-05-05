using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSONComplexExample : MonoBehaviour
{

    void Start()
    {
        SampleDataComplex sample = new SampleDataComplex();

        sample.name = "Daniel";

        sample.address = new Address();
        sample.address.unit = 123;
        sample.address.road = "Main Street";
        sample.address.city = "New York";

        sample.books = new Book[2]; //Create the array

        sample.books[0] = new Book(); //Created the object to add to the array
        sample.books[0].name = "The Lord of the Rings";
        sample.books[0].isDigital = true;
        sample.books[0].author = "Tolkien";

        sample.books[1] = new Book(); //Created the object to add to the array
        sample.books[1].name = "Harry Potter and the Philosopher's Stone";
        sample.books[1].isDigital = false;
        sample.books[1].author = "Rowling";

        string data = JsonUtility.ToJson(sample, true);
        Debug.Log(data);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
