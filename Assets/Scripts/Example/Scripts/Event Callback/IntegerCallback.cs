using UnityEngine;

public class IntegerCallback : MonoBehaviour, IGenericCallback
{
    /// <summary>
    /// Event Callback
    /// </summary>
    /// <param name="param">parameter fetch</param>
    public void OnEventRaisedCallback(params object[] param)
    {
        int value = (int) param[0];
        
        Debug.Log(value);
    }
}
