using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField]
    private Camera _moveCamera = default;

    private void OnTriggerStay2D(Collider2D collision)
    {
        float newY = collision.transform.position.y;
        if(newY > _moveCamera.transform.position.y)
        {
            _moveCamera.transform.position = new Vector3(_moveCamera.transform.position.x, newY, _moveCamera.transform.position.z);
        }
    }
}
