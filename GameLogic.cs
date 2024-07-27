using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public InputField userInput;
    public Text affich;
    int randomNum;
    public int minValeur;
    public int maxValeur;
    public Button gameButton;
    private bool isGameWon = false;
    // Start is called before the first frame update
    void Start()
    {
        ResetGame();
    }

    void ResetGame()
    {
        if (isGameWon)
        {
            affich.text = "You WON! ay Guess a num between " + minValeur + " and " + (maxValeur - 1) +" mrr okhra";
            isGameWon = true;
        }
        else
        {
            affich.text = "Guess a num between " + minValeur + " and " + (maxValeur - 1);
        }
        userInput.text = "";
        randomNum = GetRandomNum(minValeur, maxValeur);
    }

    public void ButtonClick()
    {
        string userInputValue = userInput.text;
        if (userInputValue != "")
        {
            int reponse = int.Parse(userInputValue);

            if (reponse == randomNum)
            {
                affich.text = "Correct!";
                //gameButton.interactable = false;
                isGameWon = true;
                ResetGame();
            }
            else if (reponse > randomNum)
            {
                affich.text = "Try Lower!";
            }
            else
            {
                affich.text = "Try Higher!";
            }
        }
        else
        {
            affich.text = "Entrer un entier SVP!!";
        }
        
    }

    private int GetRandomNum (int min , int max)
    {
        int random = Random.Range(min, max);
        return random;
    } 
}
