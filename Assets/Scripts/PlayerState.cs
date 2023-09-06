using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Special data type to represent the player's state at a given point, contains position and health, as well as the time it was sampled at
[System.Serializable]
public struct PlayerState
{
    public Vector3 Position;
    public int Health;
    public double Timestamp;

    public PlayerState(Vector3 position, int health, double timestamp)
    {
        Position = position;
        Health = health;
        Timestamp = timestamp;
    }
}
