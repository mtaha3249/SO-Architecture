using UnityEngine;

public class FetchInteger : MonoBehaviour
{
    /// <summary>
    /// Variable of integer type
    /// </summary>
    public GenericReference<int> _variable;

    /// <summary>
    /// Fetch Variable
    /// </summary>
    public void FetchVariable()
    {
        Debug.Log(_variable.Value);
    }
}
