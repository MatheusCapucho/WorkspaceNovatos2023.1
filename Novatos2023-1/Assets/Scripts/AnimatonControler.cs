using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatonControler : MonoBehaviour
{

    private Animator animator;

    void Start()
    {
        animator= GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.V))
        {
            animator.SetTrigger("TriggerIdle");
        }
    }
}
