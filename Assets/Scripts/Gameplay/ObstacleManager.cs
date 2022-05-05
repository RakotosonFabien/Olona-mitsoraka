using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    [Header("Game Objects")]
    public GameManager gameManager;
    public GameObject obstaclePrefab;

    [Header("Variables")]
    public float timerObstacle = 2f;
    public Vector2 screenBounds;


    // Generation d'obstacles
    private void CreerObstacle()
    {
        GameObject obstacle = Instantiate(obstaclePrefab);
        obstacle.SetActive(true);
        Vector3 position = new Vector3(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y, 0);
        obstacle.transform.position = position;
        obstacle.transform.parent = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.transform.position.x + Screen.width, Camera.main.transform.position.y - (Screen.height / 2)));
        if (gameManager.perso.plongee)
        {
            timerObstacle -= Time.deltaTime;
            if (timerObstacle < 0)
            {
                timerObstacle = 0.5f;
                CreerObstacle();
            }
        }
    }
}
