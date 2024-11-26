using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MainController : MonoBehaviour
{
    [SerializeField] private Selector selector;

    #region Events method
    private void Selector_OnSelectInstrument(Multimetr obj)
    {
        obj.OnInstrument();
    }
    private void Selector_OnUnselectInstrument(Multimetr obj)
    {
        obj.OffInstrument();
    }
    #endregion

    void Start()
    {
        selector.OnSelectInstrument += Selector_OnSelectInstrument;
        selector.OnUnselectInstrument += Selector_OnUnselectInstrument;
    }

    
}
