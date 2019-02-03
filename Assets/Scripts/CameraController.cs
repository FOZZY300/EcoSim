using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public Camera m_OrthographicCamera;

    // Adjustable values
    public int edgeSize;                            // Size of the margin at the edge of the screen to allow the curser to move the camera
    public float cameraSpeed;                       // Camera scroll speed
    public float zoomSpeed;                         // Camera zoom speed
    public float minZoom;                           // Most zoomed in 
    public float maxZoom;                           // Most zoomed out

    //Camera restraints
    //int maxX, minX, maxY, minY;

    void Update()
    {              
        float zoom = Input.GetAxis("Mouse ScrollWheel");
        float speedChange = m_OrthographicCamera.orthographicSize / 5;                      //Changes the speed of the camera based on size
        m_OrthographicCamera.orthographicSize -= zoom * zoomSpeed * speedChange;            // Camera zoom

        if (m_OrthographicCamera.orthographicSize < minZoom)
        {
            m_OrthographicCamera.orthographicSize = minZoom;
        }
        if (m_OrthographicCamera.orthographicSize > maxZoom)
        {
            m_OrthographicCamera.orthographicSize = maxZoom;
        }

        Vector3 up = new Vector3(0, 1, 0);
        Vector3 down = new Vector3(0, -1, 0);
        Vector3 left = new Vector3(-1, 0, 0);
        Vector3 right = new Vector3(1, 0, 0);

        Vector3 p_Velocity = new Vector3();
        Vector3 m_Position = new Vector3();
        m_Position = Input.mousePosition;

        if (Input.GetKey(KeyCode.W) || m_Position[1] > Screen.height - edgeSize)            // up
        {
            p_Velocity += up * cameraSpeed * speedChange;
        }
        if (Input.GetKey(KeyCode.S) || m_Position[1] < edgeSize)                            // down
        {
            p_Velocity += down * cameraSpeed * speedChange;
        }
        if (Input.GetKey(KeyCode.A) || m_Position[0] < edgeSize)                            // left
        {
            p_Velocity += left * cameraSpeed * speedChange;
        }
        if (Input.GetKey(KeyCode.D) || m_Position[0] > Screen.width - edgeSize)             // right
        {
            p_Velocity += right * cameraSpeed * speedChange;
        }

        transform.Translate(p_Velocity, Space.World);                                       // Moves camera
    } 
}