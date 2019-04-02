using System.Collections;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform player;
    public float smoothSpeed = 0.2f;

    private Vector3 offset = new Vector3(0.0f, 0.0f, -1f);


    private void LateUpdate()
    {
        transform.position = player.position + offset;
    }


}
