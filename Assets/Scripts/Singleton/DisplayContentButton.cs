using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayContentButton : MonoBehaviour
{
    public Text textUI;
    public void DisplayContent(string content)
    {
        textUI.text = content;
    }
}
