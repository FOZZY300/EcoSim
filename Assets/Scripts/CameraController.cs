using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public Camera m_OrthographicCamera;
    
    void FixedUpdate()
    {
        // Adjustable values
        int edgeSize = 10;                          // Size of the margin at the edge of the screen to allow the curser to move the camera
        float cameraSpeed = 1.0f;                   // Camera scroll speed
        float zoomSpeed = 2.0f;                     // Camera zoom speed

        //Camera restraints
        //int maxX, minX, maxY, minY, minZoom, maxZoom;
        
        
        Vector3 up = new Vector3(0, 1, 0);
        Vector3 down = new Vector3(0, -1, 0);
        Vector3 left = new Vector3(-1, 0, 0);
        Vector3 right = new Vector3(1, 0, 0);

        float zoom = Input.GetAxis("Mouse ScrollWheel");
        m_OrthographicCamera.orthographicSize -= zoom * zoomSpeed;                          // Camera zoom
                
        Vector3 p_Velocity = new Vector3();
        Vector3 m_Position = new Vector3();
        m_Position = Input.mousePosition;

        if (Input.GetKey(KeyCode.W) || m_Position[1] > Screen.height - edgeSize)            // up
        {
            p_Velocity += up * cameraSpeed;
        }
        if (Input.GetKey(KeyCode.S) || m_Position[1] < edgeSize)                            // down
        {
            p_Velocity += down * cameraSpeed;
        }
        if (Input.GetKey(KeyCode.A) || m_Position[0] < edgeSize)                            // left
        {
            p_Velocity += left * cameraSpeed;
        }
        if (Input.GetKey(KeyCode.D) || m_Position[0] > Screen.width - edgeSize)             // right
        {
            p_Velocity += right * cameraSpeed;
        }

        transform.Translate(p_Velocity, Space.World);                                       // Moves camera
    } 
}