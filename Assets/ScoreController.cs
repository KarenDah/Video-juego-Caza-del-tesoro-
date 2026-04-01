using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    // Static variables do not reset when reloading the scene
    public static int karenPoints = 0;
    public static int nahumPoints = 0;

    public TextMeshProUGUI scoreText;

    void Start()
    {
        UpdateInterface();
    }

    public void AddPoint(string winner)
    {
        if (winner == "BLUE") karenPoints++;
        else if (winner == "RED") nahumPoints++;

        UpdateInterface();
    }

    void UpdateInterface()
    {
        if (scoreText != null)
        {
            scoreText.text = "KAREN: " + karenPoints + "    NAHUM: " + nahumPoints;
        }
    }

    // This function will be used to reset when returning to the main menu
    public static void ResetGlobalScore()
    {
        karenPoints = 0;
        nahumPoints = 0;
    }
}
