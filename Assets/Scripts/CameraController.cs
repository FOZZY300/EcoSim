using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    void Update()
    {
        Vector3 p_Velocity = new Vector3();
        Vector3 p_Angle = new Vector3();
        Vector3 p_Zoom = new Vector3();
        int zoom_Speed = 10;

        float zoom = Input.GetAxis("Mouse ScrollWheel");
        p_Zoom = new Vector3(0, 0, zoom * zoom_Speed);

        if (Input.GetKey(KeyCode.W))
        {
            p_Velocity += new Vector3(0, 1, 1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            p_Velocity += new Vector3(0, -1, -1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            p_Velocity += new Vector3(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            p_Velocity += new Vector3(1, 0, 0);
        }

        if (Input.GetKey(KeyCode.E))
        {
            p_Angle += new Vector3(0, 1, 0);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            p_Angle += new Vector3(0, -1, 0);
        }

        transform.Translate(p_Zoom);
        transform.Rotate(p_Angle, Space.World);
        transform.Translate(p_Velocity);
    } 
}
