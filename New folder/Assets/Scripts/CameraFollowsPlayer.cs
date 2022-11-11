using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class CameraFollowsPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset; 

    // Update is called once per frame
    void Update()
    {
        // Camera follows the player with specified offset position
        transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, offset.z);

    }
}
