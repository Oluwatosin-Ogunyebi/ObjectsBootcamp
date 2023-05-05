using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableObjectDataSample", menuName = "CS/Create", order = 1)]
public class ScriptableObjectData : ScriptableObject
{
    public string objectName;
    public float score;
    public Vector2 position;

}
