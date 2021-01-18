using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gamer : MonoBehaviour
{
   [SerializeField] int max;
   [SerializeField] int min;
   [SerializeField] TextMeshProUGUI guesstext;
    int guess;



    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
       
    }

   

    public void OnpressHigher()
    {
        min = guess + 1;
        NextGuess();
    }



    public void OnpressLower()
    {
        max = guess - 1;
        NextGuess();
    }


    void NextGuess()
    {
        guess = Random.Range(min,max + 1);
        guesstext.text = guess.ToString();
    }


}

