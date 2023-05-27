using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineExample : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("Start" + Time.time);
        StartCoroutine(CoroutineExemplification());
    }
    void Update()
    {
        
    }

    IEnumerator CoroutineExemplification()
    {
        yield return new WaitForSeconds(1f);
        Debug.Log("Coroutine" + Time.time);
    }

}
