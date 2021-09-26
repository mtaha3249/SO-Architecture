using UnityEngine;

public class RaiseGameObject : MonoBehaviour, IRaise<GameObject>
{
    /// <summary>
    /// Event to raise
    /// </summary>
    public GameEvent _gameEvent;
    
    /// <summary>
    /// Raise GameObject event base on given value
    /// </summary>
    /// <param name="value">value to pass</param>
    public void Raise(GameObject value)
    {
        _gameEvent.Raise(value);
    }
}
