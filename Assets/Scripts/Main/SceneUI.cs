using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SceneUI : MonoBehaviour
{
    public static SceneUI Instance
    {
        get;
        private set;
    }

    [SerializeField] private TextMeshProUGUI screenValueV;
    [SerializeField] private TextMeshProUGUI screenValueA;
    [SerializeField] private TextMeshProUGUI screenValue_V;
    [SerializeField] private TextMeshProUGUI screenValueR;

    public TextMeshProUGUI ScreenValueV => screenValueV;
    public TextMeshProUGUI ScreenValueA => screenValueA;
    public TextMeshProUGUI ScreenValue_V => screenValue_V;
    public TextMeshProUGUI ScreenValueR => screenValueR;

    public void SetEmtyValue()
    {
        screenValueV.text = "0";
        screenValueA.text = "0";
        screenValue_V.text = "0";
        screenValueR.text = "0";
    }

    private void Awake()
    {
        Instance = this;   
        SetEmtyValue();
    }

    
}
