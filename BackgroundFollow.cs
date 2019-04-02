using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundFollow : MonoBehaviour
{

    public Transform followBackground;
    public Transform player;


    void Update()
    {
        followBackground.position = new Vector3(player.position.x, 0, 0);
    }
}
