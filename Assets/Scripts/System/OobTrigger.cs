using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OobTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // TODO: Trigger game over sequence where camera follows squiggle down a short distance
        Debug.Log("Game Over!");
    }
}
