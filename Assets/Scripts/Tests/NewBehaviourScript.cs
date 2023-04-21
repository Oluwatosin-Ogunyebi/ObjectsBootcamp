using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public CurrentStage currentStage;

    public enum CurrentStage
    {
        Started, 
        Stopped,
        Paused
    }

    string s1 = "hello";
    string s2 = "hello";
    string s3 = new string(new char[] { 'h', 'e', 'l', 'l', 'o' });
    // Start is called before the first frame update
    void Start()
    {
        currentStage = CurrentStage.Paused;

        Debug.Log($"s1 is {s1} , s2 is {s2} and s3 is {s3}");

        //Compare s1 and s2 using Equals()
        Debug.Log(object.Equals(s1, s2));

        //Compare s1 and s3 using Equals()
        Debug.Log(object.Equals(s1, s3));

        //Compare s1 and s2 using ReferenceEquals()
        Debug.Log(object.ReferenceEquals(s1, s2));

        //Compare s1 and s3 using ReferenceEquals()
        Debug.Log(object.ReferenceEquals(s1, s3));

        Utilities.CalculateCurrentValue(5, 9);

        Debug.Log($"The current value is {Utilities.CurrentValue}");

        Utilities.CalculateCurrentValue(5, 9,7);

        Debug.Log($"The current value using second overload is {Utilities.CurrentValue}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
