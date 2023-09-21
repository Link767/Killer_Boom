using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        MoveLogic();
    }

    private void MoveLogic()
    { 
        //Move
        float hor = Input.GetAxis("Horizontal");
        Vector2 move = new Vector2(hor, 0);
        _rb.velocity = move * _speed;
    }
}
