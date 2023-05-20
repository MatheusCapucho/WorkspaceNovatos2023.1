using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    private Vector3 _input;
    private Rigidbody2D _rigidbody;
    private Collider2D _collider;
    [SerializeField]
    private float _velocity = 5f;

    void Start()
    {
 
    }

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _collider = GetComponent<Collider2D>();

    }
   

    void Update()
    {
        _input.x = Input.GetAxisRaw("Horizontal");
        _input.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.M))
        {
            ApertarBorao();
        }


    }

    private void ApertarBorao()
    {
      
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = _velocity * _input; // Vector2(1f, 0f);
    }
}
