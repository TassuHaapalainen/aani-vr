using BNG;
using UnityEngine;

public enum Cardinal { West, East, North, South }

public class playerMovementti : MonoBehaviour
{
    public Transform headPosition;
    [SerializeField] Cardinal headDirection;

    public GameObject playerObject;
    playerInfo player;
    void Start()
    {
        //player = playerObject.GetComponentInChildren<playerInfo>();
        // transform.position = player.GetLocation() + new Vector3(10, 4, 0);

    }
    // Update is called once per frame
    void Update()
    {
        // Get the left thumbstick input
        Vector2 leftThumbstickInput = InputBridge.Instance.LeftThumbstickAxis;

        // Check which cardinal direction the player is looking at
        //if (headPosition.rotation.y > -45 && headPosition.rotation.y < 45) headDirection = Cardinal.North;

        if (headPosition.rotation.eulerAngles.y >= 315 || headPosition.rotation.eulerAngles.y < 45)
        {
            headDirection = Cardinal.North;
        }
        else if (headPosition.rotation.eulerAngles.y >= 45 && headPosition.rotation.eulerAngles.y < 135)
        {
            headDirection = Cardinal.East;
        }
        else if (headPosition.rotation.eulerAngles.y >= 135 && headPosition.rotation.eulerAngles.y < 225)
        {
            headDirection = Cardinal.South;
        }
        else if (headPosition.rotation.eulerAngles.y >= 225 && headPosition.rotation.eulerAngles.y < 315)
        {
            headDirection = Cardinal.West;
        }



        Debug.Log("Head Direction: " + headDirection);
        Debug.Log("Head Rotation Y: " + headPosition.rotation.eulerAngles.y);


        // Check if the X-axis of the thumbstick input is less than -0.1 (indicating leftward movement)
        if (leftThumbstickInput.x < -0.1f)
        {
            // The player is moving the thumbstick to the left
            Debug.Log("Moving thumbstick to the left");




        }
    }

    //movement happening hereee
    void MoveInGRid(Cardinal moveWorldDirecion)
    {
       // Debug.Log(Cardinal.North);
    }
}
