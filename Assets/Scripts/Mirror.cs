using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour
{
    public Transform player;
    public Transform plate;

    //private Camera camera;

    //private void Awake()
    //{
    //    camera = GetComponent<Camera>();
    //}

    //private void OnPreCull()
    //{
    //    camera.ResetProjectionMatrix();
    //    camera.projectionMatrix = camera.projectionMatrix * Matrix4x4.Scale(new Vector3(-1, 1, 1));
    //}

    //private void OnPreRender()
    //{
    //    GL.invertCulling = true;
    //}

    //private void OnPostRender()
    //{
    //    GL.invertCulling = false;
    //}

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(0, player.position.y, 0);

        //Vector3 localPlayer = plate.InverseTransformPoint(player.position);
        //transform.position = plate.TransformPoint(new Vector3(0, localPlayer.y, 0));

        //Vector3 localPlayer = plate.InverseTransformPoint(player.position);
        //Debug.Log(localPlayer.ToString());
        //transform.position = plate.TransformPoint(new Vector3(localPlayer.x, localPlayer.y, localPlayer.z));

        //Vector3 localMirror = plate.TransformPoint(new Vector3(-localPlayer.x, localPlayer.y, localPlayer.z));
        //Debug.Log(localMirror.ToString());
        //transform.LookAt(localMirror);
    }
}
