using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class AutoJumper : MonoBehaviour
{
    [SerializeField]
    private float _jumpVelocity = 1f;

    private Rigidbody2D _rb;
    private Collider2D _feetCollider;

    private bool _grounded = false;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _feetCollider = GetComponent<Collider2D>();
    }

    private void FixedUpdate()
    {
        if(_grounded)
        {
            jump();
            _grounded = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        checkGrounded();
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
        // Because for some reason the 2D physics doesn't have feature parity with 3D?
        // ForceMode2D does not have VelocityChange
        // Wait...Rigidbody2D has gravity scale and 3D doesn't? What is this nonsense?
        _rb.velocity = new Vector2(_rb.velocity.x, _jumpVelocity);
    }
}
