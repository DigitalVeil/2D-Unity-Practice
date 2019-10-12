using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] private State startState;

    
    private State state; 
    // Start is called before the first frame update
    void Start()
    {
        state = startState;
        textComponent.text = state.GetStateStory();
        
    }

    // Update is called once per frame
    void Update()
    {
        StateManager();
    }

    private void StateManager()
    {
        var gameStates = state.GetGameState();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = gameStates[0];
        }
        
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = gameStates[1];
        }
        
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = gameStates[2];
        }
        
        textComponent.text = state.GetStateStory();
    }
}
