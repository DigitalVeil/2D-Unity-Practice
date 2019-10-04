using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{        
    
         int maxNumber = 1000;
         int minNumber = 1;
         int guessNumber = 500;
         
    // Start is called before the first frame update
    void Start()
    {  
        GameStart();
    }

    void GameStart()
    {
        maxNumber = 1000;
        minNumber = 1;
        guessNumber = 500;
        
        Debug.Log("Hey there! Welcome to Number Wizard: Console Edition");
        Debug.Log("Pick a number, any number!");
        Debug.Log("Not too high though, we can only count to "  + maxNumber + "...");
        Debug.Log("Heck, you could even start at " + minNumber + "!"); 
        
        Debug.Log("Well then, let's get started shall we?");
        Debug.Log("Is your guess higher or lower than " + guessNumber + "?");
        
        Debug.Log("Up = Higher, Down = Lower, Enter = Nailed it");

        maxNumber = maxNumber + 1; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
         {
           minNumber = guessNumber;
           HighGuess();
         }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
         {
            maxNumber = guessNumber;
            LowGuess();
         }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Nice! I'm pretty good at this, huh?");
            GameStart();
        }
    }

    void HighGuess()
    {
        Debug.Log("Ah! So higher is it?");
        minNumber = guessNumber;
        guessNumber = (maxNumber + minNumber) / 2;
        Debug.Log("Alright then...how about " + guessNumber + "?");
    }

    void LowGuess()
    {
        Debug.Log("Low ball, eh? Alright...");
        maxNumber = guessNumber;
        guessNumber = (maxNumber + minNumber) / 2; 
        Debug.Log("Okay! Let's try " + guessNumber + ".");
    }
}
