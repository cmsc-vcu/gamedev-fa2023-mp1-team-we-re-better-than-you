using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    public GameObject player;
    public Transform respawnPoint;

    void Respawn()
    {
        player.transform.position = respawnPoint.position;
    }
}
