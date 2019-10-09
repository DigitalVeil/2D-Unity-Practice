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
        
    }
}
