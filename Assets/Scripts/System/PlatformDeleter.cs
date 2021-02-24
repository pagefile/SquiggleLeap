using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDeleter : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // This SHOULD be in the PlatformEater layer. If not you're going to have a bad time
        Destroy(collision.gameObject);
    }
}
