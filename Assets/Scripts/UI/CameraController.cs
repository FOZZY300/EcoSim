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
    public float maxX, minX, maxY, minY;            //Camera restraints.
    public float cameraAccelaration;

    private float acceleration;
    private float i = 1;

    void Update()
    {                      
        Vector3 up = new Vector3(0, 1, 0);
        Vector3 down = new Vector3(0, -1, 0);
        Vector3 left = new Vector3(-1, 0, 0);
        Vector3 right = new Vector3(1, 0, 0);

        Vector3 p_Velocity = new Vector3();
        Vector3 m_Position = new Vector3();
        m_Position = Input.mousePosition;

        float zoom = Input.GetAxis("Mouse ScrollWheel");
        float speedChange = m_OrthographicCamera.orthographicSize / 5;                      // Changes the speed of the camera based on size

        if (!Pause_Menu.GameIsPaused)
        {
            if (!Mouse_Over_Object.isOverUI)
            {
                m_OrthographicCamera.orthographicSize -= zoom * zoomSpeed * speedChange;            // Camera zoom
            }

            if (m_OrthographicCamera.orthographicSize < minZoom)
            {
                m_OrthographicCamera.orthographicSize = minZoom;
            }
            if (m_OrthographicCamera.orthographicSize > maxZoom)
            {
                m_OrthographicCamera.orthographicSize = maxZoom;
            }

            if (i > 5)
            {
                i = 5;
            }

            if (Input.GetKey(KeyCode.W)) // || m_Position[1] > Screen.height - edgeSize)            // up
            {
                p_Velocity += up * cameraSpeed * speedChange * i;
                i = i + cameraAccelaration;
            }
            if (Input.GetKey(KeyCode.S)) // || m_Position[1] < edgeSize)                            // down
            {
                p_Velocity += down * cameraSpeed * speedChange * i;
                i = i + cameraAccelaration;
            }
            if (Input.GetKey(KeyCode.A)) // || m_Position[0] < edgeSize)                            // left
            {
                p_Velocity += left * cameraSpeed * speedChange * i;
                i = i + cameraAccelaration;
            }
            if (Input.GetKey(KeyCode.D)) // || m_Position[0] > Screen.width - edgeSize)             // right
            {
                p_Velocity += right * cameraSpeed * speedChange * i;
                i = i + cameraAccelaration;
            }
            if (p_Velocity == new Vector3(0, 0, 0))
            {
                i = 1;
            }

            transform.Translate(p_Velocity, Space.World);                                       // Moves camera

            if (m_OrthographicCamera.transform.position.x > maxX - (m_OrthographicCamera.orthographicSize * 2.1f))
            {
                m_OrthographicCamera.transform.position = new Vector3(maxX - (m_OrthographicCamera.orthographicSize * 2.1f), m_OrthographicCamera.transform.position.y, 0);
            }
            if (m_OrthographicCamera.transform.position.x < minX + (m_OrthographicCamera.orthographicSize * 2.1f))
            {
                m_OrthographicCamera.transform.position = new Vector3(minX + (m_OrthographicCamera.orthographicSize * 2.1f), m_OrthographicCamera.transform.position.y, 0);
            }
            if (m_OrthographicCamera.transform.position.y > maxY - m_OrthographicCamera.orthographicSize)
            {
                m_OrthographicCamera.transform.position = new Vector3(m_OrthographicCamera.transform.position.x, maxY - m_OrthographicCamera.orthographicSize, 0);
            }
            if (m_OrthographicCamera.transform.position.y < minY + m_OrthographicCamera.orthographicSize)
            {
                m_OrthographicCamera.transform.position = new Vector3(m_OrthographicCamera.transform.position.x, minY + m_OrthographicCamera.orthographicSize, 0);
            }
        }
    } 
}