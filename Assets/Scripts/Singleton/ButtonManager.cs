using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public static ButtonManager instance;

    public DisplayContentButton display;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void SetContent(string content)
    {
        display.DisplayContent(content);
    }

}
