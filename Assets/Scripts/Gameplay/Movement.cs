using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour, IBasicMovement
{
    [SerializeField]
    private float _speed = 1f;

    private Rigidbody2D _rb = default;
    private Vector2 _moveVector = Vector2.zero;

    public void MoveHorizontal(float amount)
    {
        _moveVector.x = amount * _speed;
    }

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rb.velocity = new Vector2(_moveVector.x, _rb.velocity.y);
    }
}
