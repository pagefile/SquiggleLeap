using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class AutoJumper : MonoBehaviour
{
    [SerializeField]
    private float _jumpVelocity = 1f;

    private Rigidbody2D _rb = default;

    private bool _grounded = false;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if(_grounded)
        {
            jump();
            _grounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(_rb.velocity.y <= 0f)
        {
            jump();
        }
    }

    private void checkGrounded()
    {
        // This should only ever get colled after a trigger collision event
        if(_rb.velocity.y <= 0f)
        {
            _grounded = true;
        }
    }

    private void jump()
    {
        _rb.velocity = new Vector2(_rb.velocity.x, _jumpVelocity);
    }
}
