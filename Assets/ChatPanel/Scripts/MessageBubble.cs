using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MessageBubble : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI text;
    [SerializeField]
    Image background;
    [SerializeField]
    Image arrow;

    public Color BubbleColor { get { return background.color; } set { background.color = value; } }
    public string Text { get { return text.text; } set { text.text= value; } }
}
