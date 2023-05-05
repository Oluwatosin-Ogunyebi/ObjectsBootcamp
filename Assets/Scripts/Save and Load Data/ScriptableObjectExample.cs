using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableObjectExample : MonoBehaviour
{
    public ScriptableObjectData sample;
    // Start is called before the first frame update
    void Start()
    {
        if (sample == null) return;

        Debug.Log($"{sample.objectName} has a score of {sample.score} at a position of {sample.position}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
