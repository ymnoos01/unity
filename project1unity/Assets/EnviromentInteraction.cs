using UnityEngine;
using TMPro;

public class EnvironmentInteraction : MonoBehaviour
{
    public TMP_Text winText;

    private static bool hasPlayerWon = false;  // This should be static to persist across instances
    private static int requiredCoins = 4;      // Set the total number of required coins
    private static int collectedCoins = 0;     // This should be static to persist across instances

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
        // Deactivate the coin if it's still active
        if (gameObject.activeSelf)
        {
            // Deactivate the coin
            gameObject.SetActive(false);

            collectedCoins++;

            // Check if the player has collected the required number of coins
            Debug.Log("Checking win condition. Collected Coins: " + collectedCoins);
            if (collectedCoins >= requiredCoins && !hasPlayerWon)
            {
                WinGame();
            }
        }
    }

    private void WinGame()
    {
        hasPlayerWon = true;

        // Show the "You Win" text
        if (winText != null)
        {
            winText.text = "You Win!";
            winText.gameObject.SetActive(true);
            Debug.Log("Player won the game!");
        }
    }
}






