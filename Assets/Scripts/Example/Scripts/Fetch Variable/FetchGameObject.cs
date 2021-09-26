using UnityEngine;

public class FetchGameObject : MonoBehaviour
{
    /// <summary>
    /// Variable of integer type
    /// </summary>
    public GenericReference<GameObject> _variable;

    /// <summary>
    /// Fetch Variable
    /// </summary>
    public void FetchVariable()
    {
        _variable.Value = gameObject;
        Debug.Log(_variable.Value.name);
    }
}
