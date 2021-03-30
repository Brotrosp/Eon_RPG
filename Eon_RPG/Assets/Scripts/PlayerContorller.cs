using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContorller : MonoBehaviour
{
    public float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Plane playerPlane = new Plane(Vector3.up, transform.position);
        Ray raggio = UnityEngine.Camera.main.ScreenPointToRay(Input.mousePosition);
        float hitDistance = 0.0f;


    }
}
