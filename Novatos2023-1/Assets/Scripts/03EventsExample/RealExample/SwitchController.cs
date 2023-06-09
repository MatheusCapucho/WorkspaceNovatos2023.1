using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    public static Action SomethingHappened;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
            SomethingHappened?.Invoke();
    }
}
