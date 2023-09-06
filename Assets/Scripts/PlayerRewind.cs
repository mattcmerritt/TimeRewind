using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script to handle rewinding time to a previous state, based on rewind delay
public class PlayerRewind : MonoBehaviour
{
    [SerializeField] private List<PlayerState> PreviousPlayerStates = new List<PlayerState>();
    [Range(0, 10), SerializeField] private float RewindDelay;

    private void Update()
    {
        // Add new states onto end of list
        float currentTime = Time.time;
        PreviousPlayerStates.Add(new PlayerState(transform.position, GetComponent<SimplePlayerHealth>().GetHealth(), currentTime));

        // Remove states that are too old from the beginning of the list
        while (PreviousPlayerStates.Count > 0 && currentTime - PreviousPlayerStates[0].Timestamp > RewindDelay)
        {
            PreviousPlayerStates.RemoveAt(0);
        }

        // Rewind player on space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = PreviousPlayerStates[0].Position;
            GetComponent<SimplePlayerHealth>().SetHealth(PreviousPlayerStates[0].Health);
            PreviousPlayerStates.Clear();
        }
    }
}
