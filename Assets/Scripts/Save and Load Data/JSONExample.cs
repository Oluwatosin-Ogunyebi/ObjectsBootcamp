using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSONExample : MonoBehaviour
{
    public TextAsset person;
    void Start()
    {
        //Serializing data to JSON

        SampleData sample = new SampleData();

        sample.name = "Tracie";
        sample.score = 30.0f;

        string data = JsonUtility.ToJson(sample, true);
        Debug.Log(data);

        //Serialize JSON to data

        SampleData sample2 = JsonUtility.FromJson<SampleData>(person.text);
        Debug.Log($"Deserialized {sample2.name} with a score of {sample2.score}");
    }

}
