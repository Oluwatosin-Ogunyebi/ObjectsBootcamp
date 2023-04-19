using UnityEngine;
public static class Utilities
{
    public static int CurrentValue;

    public static float CalculateCurrentValue(float firstValue, float secondValue, float thirdValue = 1)
    {
        float result = (firstValue * secondValue) / thirdValue;
        CurrentValue = Mathf.RoundToInt(result);
        return result;
    }
}
