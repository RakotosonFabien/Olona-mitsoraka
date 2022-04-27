using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public SpriteRenderer fond;
    public Transform target;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        float orthoSize = fond.bounds.size.x * Screen.height / Screen.width * 0.5f;
        Camera.main.orthographicSize = orthoSize;
    }

    // Update is called once per frame
    void Update()
    {
        //avy eo avadika manaraka anle camera seulement apres premiere fois tonga eo @ milieu
        transform.position = target.position + offset;
    }
}
