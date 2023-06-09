using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAction : MonoBehaviour
{
    public Action<string> Opened;

    private void OnEnable()
    {
        Opened += OpenDoor;
        Opened += OpenChest;
    }

    private void OnDisable()
    {
        Opened -= OpenDoor;
        Opened -= OpenChest;
    }

    public void OpenDoor(string password)
    {
        if (password == "0000")
        {
            Debug.Log("Opened Door");
        }
        else
        {
            Debug.Log("Closed Door");
        }
    }

    public void OpenChest(string name)
    {

        if (name == "Capucho")
        {
            Debug.Log("Opened Chest");
        }
        else
        {
            Debug.Log("Closed Chest");
        }
    }
    private void Start()
    {
        Opened?.Invoke("0000");
    }

}
