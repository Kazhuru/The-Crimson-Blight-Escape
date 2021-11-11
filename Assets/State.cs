using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [SerializeField] int id;
    [TextArea(14, 10)] [SerializeField] string storyText;
    [TextArea(14, 10)] [SerializeField] string conversationText;
    [SerializeField] State[] nextStates;

    public int GetId()
    {
        return id;
    }

    public string GetStoryText()
    {
        return storyText;
    }

    public string GetConversationText()
    {
        return conversationText;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }
}
