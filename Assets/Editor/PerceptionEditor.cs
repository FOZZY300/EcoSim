using System.Collections;
using UnityEditor;
using UnityEngine;

[CustomEditor (typeof (Perception))]
public class PerceptionEditor : Editor
{
    private void OnSceneGUI()
    {
        //Reference to Perception script and target obj
        Perception prc = (Perception)target;
        //Sets color of circle
        Handles.color = Color.black;
        //Draws circle from position of obj, dir circle will rotate around obj, angle begins, rotates 360, actual radius
        Handles.DrawWireArc(prc.transform.position, Vector3.forward, Vector3.left, 360, prc.pRadius);
        //Declare variables for Line of SIght. angleInDegrees, angleIsGlobal
        Vector3 losAngleA = prc.DirFromAngle(-prc.pAngle / 2, false);
        Vector3 losAngleB = prc.DirFromAngle(prc.pAngle / 2, false);
        //Draws the Line of Sight cone
        Handles.DrawLine(prc.transform.position, prc.transform.position + losAngleA * prc.pRadius );
        Handles.DrawLine(prc.transform.position, prc.transform.position + losAngleB * prc.pRadius );
        //Handles.DrawWireArc(prc.transform.position, Vector3.forward, losAngleB, prc.pAngle, prc.pRadius / 2);

        //Creates a red line between targets
        Handles.color = Color.red;
        foreach (Transform visibleTarget in prc.visibleTargets)
        {
            Handles.DrawLine(prc.transform.position, visibleTarget.position);
        }
        
    }
}
