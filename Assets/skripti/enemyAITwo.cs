using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class enemyAITwo : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public float moveSpeed = 3.0f; // Speed at which the enemy moves

    private void Update()
    {
        if (player != null)
        {
            // Calculate the direction from the enemy to the player
            Vector3 moveDirection = (player.position - transform.position).normalized;

            // Move the enemy towards the player
            transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
        }
    }
}
