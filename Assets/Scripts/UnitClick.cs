using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitClick : MonoBehaviour
{
    private Camera _camera;

    // public GameObject GroundMarker;
    public LayerMask Clickable;
    public LayerMask Ground;
    public LayerMask Attackable;

    // Start is called before the first frame update
    void Start()
    {
        _camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity, Clickable))
            {
                UnitSelections.Instance.ClickSelect(hit.collider.gameObject);
            }
            else
            {
                UnitSelections.Instance.DeselectAll();
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity, Attackable))
            {
                //GroundMarker.transform.position = hit.point;
                //GroundMarker.SetActive(false);
                //GroundMarker.SetActive(true);
                foreach (var unit in UnitSelections.Instance.UnitsSelected)
                {

                }
            }
        }
    }
}
