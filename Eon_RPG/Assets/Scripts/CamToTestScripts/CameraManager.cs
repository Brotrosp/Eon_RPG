using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public CameraFollow camFollowScript;
    public CameraAxis camAxisScript;

    bool camViewChanged = false;

    // Start is called before the first frame update
    void Start()
    {
        camAxisScript.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(camViewChanged);

        if (camViewChanged == false)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                camViewChanged = true;

                camAxisScript.enabled = true;
                camFollowScript.enabled = false;
            }
        }
        else if (camViewChanged == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                camViewChanged = false;

                camAxisScript.enabled = false;
                camFollowScript.enabled = true;
            }
        }

    }
}
