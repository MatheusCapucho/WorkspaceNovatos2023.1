using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawAnimation : MonoBehaviour
{
    private Animator _animator;
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
    private void OnEnable()
    {
        SwitchController.SomethingHappened += ChangeAnimation;
    }
    private void OnDisable()
    {
        SwitchController.SomethingHappened -= ChangeAnimation;
    }

    public void ChangeAnimation()
    {
        _animator.SetTrigger("Play");
    }
}
