using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text storyComponent;
    [SerializeField] Text conversationComponent;
    [SerializeField] State startState;
    State currentState;

    // Start is called before the first frame update
    void Start()
    {
        currentState = startState;
        UpdateText();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextState = currentState.GetNextStates();
        var countChoices = nextState.Length;

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (countChoices >= 1)
            {
                currentState = nextState[0];
                UpdateText();
            }
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (countChoices >= 2)
            {
                currentState = nextState[1];
                UpdateText();
            }
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (countChoices >= 3)
            {
                currentState = nextState[2];
                UpdateText();
            }
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            currentState = startState;
            UpdateText();
        }
    }

    private void UpdateText()
    {
        storyComponent.text = currentState.GetStoryText();
        conversationComponent.text = currentState.GetConversationText();
    }
}
