using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventExample : MonoBehaviour
{
    public UnityEvent myEvent;
    void Start()
    {
        myEvent?.Invoke();
    }

}
