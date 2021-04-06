using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRoam : MonoBehaviour
{

    public float camSpeed = 20;
    public float screenSizeThickness = 10;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        //UP
        if (Input.mousePosition.y >=  screenSizeThickness)
        {
            pos.x -= camSpeed * Time.deltaTime;
        }

        //Down
        if (Input.mousePosition.y <= Screen.height - screenSizeThickness)
        {
            pos.x += camSpeed * Time.deltaTime;
        }

        //Right
        if (Input.mousePosition.x >= Screen.height - screenSizeThickness)
        {
            pos.z += camSpeed * Time.deltaTime;
        }

        //Left
        if (Input.mousePosition.x <= screenSizeThickness)
        {
            pos.z -= camSpeed * Time.deltaTime;
        }

        transform.position = pos;
    }
}
