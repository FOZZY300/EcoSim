using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public Camera m_OrthographicCamera;
    
    void Update()
    {
        int edgesize = 25;
        float zoom = 0f;
        zoom = Input.GetAxis("Mouse ScrollWheel");
        m_OrthographicCamera.orthographicSize -= zoom * 2;
                
        Vector3 p_Velocity = new Vector3();
        Vector3 m_Position = new Vector3();
        m_Position = Input.mousePosition;

        if (Input.GetKey(KeyCode.W) || m_Position[1] > Screen.height - edgesize)
        {
            p_Velocity += new Vector3(0, 1, 0);
        }
        if (Input.GetKey(KeyCode.S) || m_Position[1] < edgesize)
        {
            p_Velocity += new Vector3(0, -1, 0);
        }
        if (Input.GetKey(KeyCode.A) || m_Position[0] < edgesize)
        {
            p_Velocity += new Vector3(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.D) || m_Position[0] > Screen.width - edgesize)
        {
            p_Velocity += new Vector3(1, 0, 0);
        }

        transform.Translate(p_Velocity, Space.World);
    } 
}