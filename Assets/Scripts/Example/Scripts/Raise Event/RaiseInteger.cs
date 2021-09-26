using UnityEngine;

public class RaiseInteger : MonoBehaviour, IRaise<int>
{
    /// <summary>
    /// Event to raise
    /// </summary>
    public GameEvent _gameEvent;

    /// <summary>
    /// Raise integer event base on given value
    /// </summary>
    /// <param name="value">value to pass</param>
    public void Raise(int value)
    {
        _gameEvent.Raise(value);
    }
}