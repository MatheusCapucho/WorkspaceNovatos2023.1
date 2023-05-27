using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTeste : MonoBehaviour
{

    [SerializeField]
    private CinemachineVirtualCamera cam;

    [SerializeField]
    private GameObject qualquerObjeto;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
            cam.Follow = qualquerObjeto.transform;
    }
}
