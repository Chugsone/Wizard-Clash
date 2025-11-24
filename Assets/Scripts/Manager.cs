using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public Text Result;
    public Image AiChoice;

    // Optional: populate in Inspector or use the default in Awake if left empty
    public string[] Choices = new string[] { "Water", "Fire", "Earth" };
    public Sprite Water, Fire, Earth;

    private Dictionary<string, Sprite> _spriteMap;

    void Awake()
    {
        // Map choice names to sprites, case-insensitive
        _spriteMap = new Dictionary<string, Sprite>(System.StringComparer.OrdinalIgnoreCase)
        {
            { "Water", Water },
            { "Fire", Fire },
            { "Earth", Earth }
        };

        // Ensure we have at least the expected choices
        if (Choices == null || Choices.Length == 0)
            Choices = new[] { "Water", "Fire", "Earth" };
    }

    // Called by UI buttons, e.g. Button OnClick -> PlayGame("Water")
    public void PlayGame(string playerChoice)
    {
        if (string.IsNullOrWhiteSpace(playerChoice))
        {
            Debug.LogWarning("PlayGame called with empty playerChoice.");
            return;
        }

        // Choose AI choice
        int aiIndex = Random.Range(0, Choices.Length);
        string aiChoice = Choices[aiIndex];

        // Update AI sprite (if assigned)
        if (AiChoice != null && _spriteMap.TryGetValue(aiChoice, out var sprite) && sprite != null)
            AiChoice.sprite = sprite;

        // Determine result and update UI text (use .text not .Text)
        string outcome = DetermineResult(playerChoice, aiChoice);
        if (Result != null)
            Result.text = outcome;
    }

    // Returns "You Win!", "You Lose!" or "Tie!"
    private string DetermineResult(string player, string ai)
    {
        if (string.Equals(player, ai, System.StringComparison.OrdinalIgnoreCase))
            return "Tie!";

        // Rules: Water > Fire, Fire > Earth, Earth > Water
        bool playerWins =
            (string.Equals(player, "Water", System.StringComparison.OrdinalIgnoreCase) && string.Equals(ai, "Fire", System.StringComparison.OrdinalIgnoreCase)) ||
            (string.Equals(player, "Fire", System.StringComparison.OrdinalIgnoreCase) && string.Equals(ai, "Earth", System.StringComparison.OrdinalIgnoreCase)) ||
            (string.Equals(player, "Earth", System.StringComparison.OrdinalIgnoreCase) && string.Equals(ai, "Water", System.StringComparison.OrdinalIgnoreCase));

        return playerWins ? "You Win!" : "You Lose!";
    }
}
