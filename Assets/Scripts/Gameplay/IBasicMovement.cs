using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IBasicMovement
{
    // amount should be between -1 and 1
    void MoveHorizontal(float amount);
}
