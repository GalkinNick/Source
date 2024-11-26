using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Multimetr : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private Transform thumbler;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private Poiner pointer;
    [SerializeField] private Display display;

    private bool allowTurn;

    public void OnInstrument()
    {
        display.OnDisplay();
        allowTurn = true;
    }

    public void OffInstrument()
    {
        display.OffDisplay();
        allowTurn = false;
        SceneUI.Instance.SetEmtyValue();
    }

    private void RotateThumbler()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if ( scroll != 0f)
        {
            float valueScroll = Mathf.Clamp(scroll, -1f, 1f);
            thumbler.Rotate(0, valueScroll * rotationSpeed, 0);
        }
    }


    private void Update()
    {
        if (allowTurn) RotateThumbler();
    }

    private void Start()
    {
        OffInstrument();
    }
}
