using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Display : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private CanvasGroup display;
    [SerializeField] private TextMeshProUGUI displayText;

    private bool displayOn;
    public void OnDisplay()
    {
        if (!displayOn)
        {
            display.alpha = 1;
            displayText.text = "0";
            displayOn = true;
        }
    }

    public void OffDisplay()
    {
        if (displayOn)
        {
            display.alpha = 0;
            displayText.text = string.Empty;
            displayOn = false;
        }
    }

    public void SetDisplayTextValue(string text)
    {
        this.displayText.text = text;
    }

    private void Start()
    {
        displayOn = true;
    }


}
