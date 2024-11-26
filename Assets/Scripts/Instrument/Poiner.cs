using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Poiner : MonoBehaviour
{
    [SerializeField] private Display display;

    [Space(5f)]
    [Header("Triggers")]
    [SerializeField] private BoxCollider triggerR;
    [SerializeField] private BoxCollider triggerV;
    [SerializeField] private BoxCollider trigger_V;
    [SerializeField] private BoxCollider triggerA;

    private double rValue = 1000;
    private double pValue = 400;


    private void OnTriggerStay(Collider other)
    {
        DisplayOnMonitor(other);
    }

    private void OnTriggerEnter(Collider other)
    {
        DisplayOnMonitor(other);
    }

    private void DisplayOnMonitor(Collider other)
    {
        SceneUI.Instance.SetEmtyValue();
        switch (other.name)
        {
            case string t when t.Equals(triggerR.name):
                display.SetDisplayTextValue(GetMathRValue().ToString());
                SceneUI.Instance.ScreenValueR.text = GetMathRValue().ToString();
                break;
            case string t when t.Equals(triggerV.name):
                display.SetDisplayTextValue(GetMathVValue().ToString());
                SceneUI.Instance.ScreenValueV.text = GetMathVValue().ToString();
                break;
            case string t when t.Equals(trigger_V.name):
                display.SetDisplayTextValue(GetMath_VValue().ToString());
                SceneUI.Instance.ScreenValue_V.text = GetMath_VValue().ToString();
                break;
            case string t when t.Equals(triggerA.name):
                display.SetDisplayTextValue(GetMathAValue().ToString());
                SceneUI.Instance.ScreenValueA.text = GetMathAValue().ToString();
                break;
            default:
                display.SetDisplayTextValue("0");
                SceneUI.Instance.SetEmtyValue();
                break;
        }
    }

    private double GetMathRValue() => rValue;

    private double GetMathVValue(){
        return Math.Round(pValue / GetMathAValue(), 2);
    }

    private double GetMath_VValue(){
        return 0.01;
    }

    private double GetMathAValue(){
        double result = Math.Sqrt(pValue / rValue);
        return Math.Round(result, 2);
    }


    private void OnTriggerExit(Collider other)
    {
        display.SetDisplayTextValue("0");
    }

}
