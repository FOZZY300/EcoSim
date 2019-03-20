using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap_Controls : MonoBehaviour
{
    public Camera minimapCamera;
    public int maxZoom, minZoom;
    public float zoomSpeed;

    void Update()
    {
        float zoom = Input.GetAxis("Mouse ScrollWheel");

        if (Mouse_Over_Minimap.isOverMinimap)
        {
            minimapCamera.orthographicSize -= zoom * zoomSpeed;
        }
        if (minimapCamera.orthographicSize < minZoom)
        {
            minimapCamera.orthographicSize = minZoom;
        }
        if (minimapCamera.orthographicSize > maxZoom)
        {
            minimapCamera.orthographicSize = maxZoom;
        }
    }

    public void MinimapZoomIn()
    {
        minimapCamera.orthographicSize -= zoomSpeed;
    }

    public void MinimapZoomOut()
    {
        minimapCamera.orthographicSize += zoomSpeed;
    }
}
