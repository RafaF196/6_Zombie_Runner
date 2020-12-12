using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    [SerializeField] float zoomedOutFOV = 60;
    [SerializeField] float zoomedInFOV = 20;

    bool zoomedInToggle = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (!zoomedInToggle)
            {
                zoomedInToggle = true;
                mainCamera.fieldOfView = zoomedInFOV;
            }
            else
            {
                zoomedInToggle = false;
                mainCamera.fieldOfView = zoomedOutFOV;
            }
        }
    }
}
