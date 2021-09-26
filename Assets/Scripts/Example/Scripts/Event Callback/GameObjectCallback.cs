using UnityEngine;

public class GameObjectCallback : MonoBehaviour, IGenericCallback
{
    /// <summary>
    /// Event Callback
    /// </summary>
    /// <param name="param">parameter fetch</param>
    public void OnEventRaisedCallback(params object[] param)
    {
        GameObject go = (GameObject) param[0];

        Debug.Log(go.name);
    }
}
