using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Special data type to represent the player's state at a given point, contains position and health
[System.Serializable]
public struct PlayerState
{
    public Vector3 Position;
    public int Health;
}
