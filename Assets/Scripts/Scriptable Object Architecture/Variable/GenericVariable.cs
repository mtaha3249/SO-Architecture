using UnityEngine;

public class GenericVariable<T> : ScriptableObject
{
    [Multiline, SerializeField] private string DeveloperDescription = "";

    /// <summary>
    /// Generic default value
    /// </summary>
    [SerializeField] private T _defaultValue;

    /// <summary>
    /// Generic Original Value
    /// This is the modified value a copy of the default value so base value didn't modified
    /// </summary>
    private T _originalValue;
    private bool isDefault = true;

    private void OnEnable()
    {
        isDefault = true;
    }

    /// <summary>
    /// Value of the generic variable
    /// </summary>
    public T Value
    {
        get
        {
            if (isDefault)
                _originalValue = _defaultValue;
            return _originalValue;
        }
        set
        {
            isDefault = false;
            _originalValue = value;
        }
    }
}
