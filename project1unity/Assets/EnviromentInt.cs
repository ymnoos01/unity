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
    public int coinCounter = 2;

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
        //hasPlayerWon = true;

        // Deactivate or destroy the object
        if (objectToDisappear != null)
        {
            // Deactivate the object
            objectToDisappear.SetActive(false);

            coinCounter += 1;

            // win condition
            if(coinCounter == 2) 
            {
                hasPlayerWon = true;

                // Show the "You Win" text
                if (winText != null)
                {
                    winText.text = "You Win!";
                    winText.gameObject.SetActive(true);
                }   
            }
        }
    }

    private void win()
    {


    }
}