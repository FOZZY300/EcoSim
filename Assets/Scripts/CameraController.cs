using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    private new GameObject camera;
    void Update()
    {
        camera = GameObject.Find("Main Camera");

        float c_Position = camera.transform.position.y;
        float speed = c_Position * 0.04f;
        

        Vector3 p_Velocity = new Vector3(0, 0, 0);
        
        Vector3 p_Zoom = new Vector3();        
        int zoom_Speed = 10;
    
        float zoom = Input.GetAxis("Mouse ScrollWheel");
        p_Zoom = new Vector3(0, 0, zoom * zoom_Speed * speed);

        if (Input.GetKey(KeyCode.W))
        {
            p_Velocity += new Vector3(0, 0, 1 * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            p_Velocity += new Vector3(0, 0, -1 * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            p_Velocity += new Vector3(-1 * speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            p_Velocity += new Vector3(1 * speed, 0, 0);
        }
        
        transform.Translate(p_Zoom);
        transform.Translate(p_Velocity, Space.World);
    } 
}
