using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public Camera m_OrthographicCamera;
    
    void Update()
    {
        float zoom = 0f;
        zoom = Input.GetAxis("Mouse ScrollWheel");
        m_OrthographicCamera.orthographicSize -= zoom * 2;
                
        Vector3 p_Velocity = new Vector3();       
        
        if (Input.GetKey(KeyCode.W))
        {
            p_Velocity += new Vector3(0, 1, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            p_Velocity += new Vector3(0, -1, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            p_Velocity += new Vector3(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            p_Velocity += new Vector3(1, 0, 0);
        }
        
        transform.Translate(p_Velocity, Space.World);
    } 
}
