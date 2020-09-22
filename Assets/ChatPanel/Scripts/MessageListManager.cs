using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageListManager : MonoBehaviour
{
    public GameObject BotMessageTemplate;
    public GameObject UserMessageTemplate;
    public RectTransform Parent;

    public void AddReceivedMessage(string message)
    {
        AddMessage(BotMessageTemplate, message);
    }

    public void AddUserMessage(string message)
    {
        AddMessage(UserMessageTemplate, message);
    }

    void AddMessage(GameObject prefab, string message)
    {
        var temp = Instantiate(prefab, Parent);

        var bubble = temp.GetComponent<MessageBubble>();

        bubble.Text = message;

    }



}
