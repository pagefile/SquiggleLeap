using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileInput : MonoBehaviour
{
    //private LineRenderer _line;

    private IBasicMovement _bm = default;

    private void Start()
    {
        //_line = gameObject.AddComponent<LineRenderer>();
        //_line.startWidth = 0.1f;
        //_line.endWidth = 0.1f;
        //_line.startColor = Color.red;
        //_line.endColor = Color.red;
        //_line.SetPosition(0, Vector3.zero);
        //_line.SetPosition(1, new Vector3(Input.acceleration.x, Input.acceleration.y, 0f));
        _bm = GetComponent<IBasicMovement>();
    }

    void Update()
    {
        //_line.SetPosition(0, gameObject.transform.position);
        //_line.SetPosition(1, gameObject.transform.position + new Vector3(Input.acceleration.x, Input.acceleration.y, 0f));
        _bm?.MoveHorizontal(Input.acceleration.x);
    }
}
