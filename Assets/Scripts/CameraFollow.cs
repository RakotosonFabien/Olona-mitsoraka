using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public bool stop = false;
    public SpriteRenderer fond;
    public Transform target;
    public Vector3 offset;
    public Vector3 premiereDistance;
    // Start is called before the first frame update
    void Start()
    {
        premiereDistance = new Vector3(0, this.transform.position.y - target.transform.position.y, 0);
        float orthoSize = fond.bounds.size.x * Screen.height / Screen.width * 0.5f;
        Camera.main.orthographicSize = orthoSize;
    }

    // Update is called once per frame
    void Update()
    {
        if (!stop)
        {
            transform.position = new Vector3(0, target.position.y, 0) + offset + premiereDistance;
        }
    }
}
