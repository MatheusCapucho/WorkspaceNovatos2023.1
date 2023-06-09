using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleDelegate : MonoBehaviour
{
    public delegate void Opened(string str); // Mesma assinatura das funções
    public void OpenDoor(string password)
    {
        if(password == "0000")
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
        Opened delegateObject = new Opened(OpenDoor);
        delegateObject?.Invoke("0123");
    
        /* 
         * O ponto de interrogacao depois do nome da variavel verifica se ela é NULL antes de invocar o metodo Invoke();
         * if (delegateObject != null)
            delegateObject.Invoke("0123"); 
        */

        delegateObject = new Opened(OpenChest);
        delegateObject?.Invoke("Capucho");

    }

}
