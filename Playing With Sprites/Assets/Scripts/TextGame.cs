using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextGame : MonoBehaviour
{
    [SerializeField] Text textComponent; 
    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = ("When humanity is at its end, what will your last moments be? ");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
