using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraJeu : MonoBehaviour
{
    [Header("Game Objects")]
    public SpriteRenderer fond;
    public Transform target;
    
    [Header("Variables")]
    public bool stop = false;
    public Vector3 offset;
    private Vector3 premiereDistance;

    public void StopFollowing(bool value) => this.stop = value;

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
