using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
    public Text guessText;
    int max;
    int min;
    int guess;

    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1001;
        min = 1;
        print("la");
        NextGuess();
        guessText.text = guess.ToString();
    }

    void NextGuess()
    {
        print(min);
        print(max);
        guess = Random.Range(min, max);
        guessText.text = guess.ToString();
    }

    public void GuessHigher() {
        min = guess;
        NextGuess();
    }

    public void GuessLower() {
        max = guess;
        NextGuess();
    }

    public void GuessCorrect () {
        StartGame();
    }
}
