using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public string myContent;

    public void SendContent()
    {
        ButtonManager.instance.SetContent(myContent);
    }
}
