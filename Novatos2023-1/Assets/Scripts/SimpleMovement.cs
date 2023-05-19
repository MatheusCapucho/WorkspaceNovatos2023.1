using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    private Vector3 _input;
    private Rigidbody2D _rigidbody;
    [SerializeField]
    private float _velocity = 5f;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _input.x = Input.GetAxisRaw("Horizontal");
        _rigidbody.velocity = _velocity * _input;
    }
}
