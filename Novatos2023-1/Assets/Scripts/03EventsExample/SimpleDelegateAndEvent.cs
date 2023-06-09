using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleDelegateAndEvent : MonoBehaviour
{
    public delegate void OpenedEventHandler(string str);
    public event OpenedEventHandler Opened;
    private void OnEnable()
    {
        Opened += new OpenedEventHandler(OpenDoor);
        Opened += new OpenedEventHandler(OpenChest);
    }

    private void OnDisable()
    {
        Opened -= new OpenedEventHandler(OpenDoor);
        Opened -= new OpenedEventHandler(OpenChest);
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
