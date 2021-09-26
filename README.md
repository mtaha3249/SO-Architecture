# Scriptable Object Architecture
This is a scriptable object architecture followed by [Ryan Hipple](https://github.com/roboryantron) [Talk](https://www.youtube.com/watch?v=raQ3iHhE_Kk).

This package is made from **Unity 2020.3.0f1**

---
#### How to create Scriptable Object?
To create scriptable object **_right click in Project Window => Create => SO-Architecture_**

<img width="511/2" alt="Screenshot 2021-09-26 at 3 51 45 PM" src="https://user-images.githubusercontent.com/38559882/134805979-f378a58d-a5cf-47a1-8480-261afb635314.png">

---
#### How to add event listener?
Add a script named as `GameEventListener.cs`

<img width="390/2" alt="Screenshot 2021-09-26 at 3 58 11 PM" src="https://user-images.githubusercontent.com/38559882/134806040-33d4aed9-707f-4b86-9519-978b5b67085d.png">


#### API
```c#
// Event to Listen
public GameEvent Event;
// public Unity Event, which to be happen when event is raised
public UnityEvent<object[]> Response;
```

---
#### How to Create New Variable Type?
Go to the Menu Item => SO-Architecture => New Variable Type

<img width="144" alt="Screenshot 2021-09-26 at 4 38 50 PM" src="https://user-images.githubusercontent.com/38559882/134806099-ade88ac3-0407-4cc8-bf4e-d87830ef4a66.png">


Now you will see a window open

<img width="596" alt="Screenshot 2021-09-26 at 4 38 59 PM" src="https://user-images.githubusercontent.com/38559882/134806113-54107576-0f78-41a9-b599-bbb5810a4851.png">

In this picture you see, assign a new variable type that can be variable type i.e. `float`, `bool`, `int`, `LayerMask` or any custom struct or enum.
These given type are already created using this window
* Bool
* Int
* Float
* Vector2
* Vector3
* GameObject
* Transform
* Quaternion

---
### How to get event callback?
In your class simply implement the interface `IGenericCallback.cs`, and write you functionality in the generated function.
You can parse variable from object to any type. If you don't know about parsing data follow [this](https://exceptionnotfound.net/csharp-in-simple-terms-3-casting-conversion-parsing-is-as-and-typeof/) link.

### Code Example
In this example you can see i am handling the callback of integer, and parsing the variable.
```c#
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
```

---
### How to Raise Event?
In your class implement the interface `IRaise.cs`, and give the type of event you are going to raise.

### Code Example
In this example you can see i am raising the integer event. You can implement multiple interface for multiple type raising, or you can raise event manually.
```c#
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
```

---
### How to fetch value from variable?
In your class create a variable type of Generic Reference, and pass the type of variable you want to create. You can see the variable in the inspector.

![ezgif com-gif-maker](https://user-images.githubusercontent.com/38559882/134805832-c84b6bc0-428f-4eba-bb32-53152129c763.gif)

#### Code Example
```c#
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
```
