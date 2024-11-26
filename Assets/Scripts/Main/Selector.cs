using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Selector : MonoBehaviour
{
    public event Action<Multimetr> OnSelectInstrument;
    private void DoSelectInstrument(Multimetr multimetr) { OnSelectInstrument?.Invoke(multimetr); }

    public event Action<Multimetr> OnUnselectInstrument;
    private void DoUnselectInstrument(Multimetr multimetr) {OnUnselectInstrument?.Invoke(multimetr); }



    private Camera _camera;
    private Multimetr tempMultimetr;

    public Multimetr Raycast()
    {
        RaycastHit hit;
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            var multimetr = hit.transform.GetComponent<Multimetr>();

            if (multimetr == null)
                multimetr = hit.transform.GetComponentInParent<Multimetr>();

            return multimetr;
        }

        return null;
    }

    private void SelectInstrument()
    {
        Multimetr multimetr = Raycast();

        if (multimetr != null)
        {
            DoSelectInstrument(multimetr);
            tempMultimetr = multimetr;
        } else if (tempMultimetr != null)
        {
            DoUnselectInstrument(tempMultimetr);
        }
    }

    private void Update()
    {
        SelectInstrument();
    }

    private void Start()
    {
        _camera = GetComponent<Camera>();
    }
}
