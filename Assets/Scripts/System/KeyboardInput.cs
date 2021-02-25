using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    private IBasicMovement _bm = default;
    
    private void Start()
    {
        // There might be a better method of getting this reference, but I'm
        // going with this for now
        _bm = GetComponent<IBasicMovement>();
    }

    void Update()
    {
        _bm?.MoveHorizontal(Input.GetAxis("Horizontal"));
    }
}
