using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worldPositioning : MonoBehaviour
{
    public GameObject playerObject;
    playerInfo player;

    private float beatInterval; // Time between beats in seconds
    private float lastBeatTime;

    private float lastMoveTime;
    private float moveInterval = 0.1f; // Time between allowed moves




    // Start is called before the first frame update
    void Start()
    {
        player = playerObject.GetComponentInChildren<playerInfo>();
        transform.position = player.GetLocation() + new Vector3(10, 4, 0);

        beatInterval = 60f / 139;


    }

    // Update is called once per frame
    void Update()
    {







        // Check if it's time to move on the beat
        if (CanJumpInRange(beatInterval, .27f))


        {
            // Detect input and move the player
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.Translate(2, 0, 0);
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                transform.Translate(0, 0, 2);
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.Translate(0, 0, -2);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.Translate(-2, 0, 0);
            }

            // Update the last beat time
            lastBeatTime = Time.time;
        }

        // Update the last move time
        lastMoveTime = Time.time;



    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="interval">how often the check is made (every x seconds)</param>
    /// <param name="pressRange">how much time one has to press the button</param>
    /// <returns></returns>
    bool CanJumpInRange(float interval, float pressRange)
    {
        float timeLine = Time.time; // change to music timeline if needed

        float x = timeLine % interval; //calculation
        float pressRangeSide = pressRange / 2; //one side of range
        return (x >= interval - pressRangeSide || x <= pressRangeSide); //muokattu
    }
}


