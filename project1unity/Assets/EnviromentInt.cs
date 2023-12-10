using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnviromentInt : MonoBehaviour
{
    public GameObject objectToDisappear;
    public TMP_Text winText;

    public bool hasPlayerWon = false;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object is the player
        if (other.CompareTag("Player"))
        {
            // Perform the environment reaction
            ReactToPlayer();
        }
    }

    private void ReactToPlayer()
    {
        hasPlayerWon = true;

        // Deactivate or destroy the object
        if (objectToDisappear != null)
        {
            // Deactivate the object
            objectToDisappear.SetActive(false);

            // Show the "You Win" text
            if (winText != null)
            {
                winText.text = "You Win!";
            }
        }
    }
}