using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class RTSPlayerController : MonoBehaviour
{
    public Camera playerCamera;
    public Vector3 cameraOffset;
    public GameObject targetIndicatorPrefab;
    NavMeshAgent agent;
    GameObject targetObject;

    // Use this for initialization
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        //Instantiate click target prefab
        if (targetIndicatorPrefab)
        {
            targetObject = Instantiate(targetIndicatorPrefab, Vector3.zero, Quaternion.identity) as GameObject;
            targetObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

        //Handle mouse input
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            MoveToTarget(Input.mousePosition);
        }

        //Camera follow
        playerCamera.transform.position = Vector3.Lerp(playerCamera.transform.position, transform.position + cameraOffset, Time.deltaTime * 20f);
        playerCamera.transform.LookAt(transform);
    }

    void MoveToTarget(Vector2 posOnScreen)
    {
        //print("Move To: " + new Vector2(posOnScreen.x, Screen.height - posOnScreen.y));

        Ray screenRay = playerCamera.ScreenPointToRay(posOnScreen);

        RaycastHit hit;
        if (Physics.Raycast(screenRay, out hit, 75))
        {
            agent.destination = hit.point;

            //Show marker where we clicked
            if (targetObject)
            {
                targetObject.transform.position = agent.destination;
                targetObject.SetActive(true);
            }
        }
    }
}