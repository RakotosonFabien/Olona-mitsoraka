using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenObstacle : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float timerObstacle = 0.5f;
    public Vector2 screenBounds;
    public GameObject perso;
    //Creation obstacles
    private void CreerObstacle()
    {
        GameObject gamePlay = GameObject.FindGameObjectWithTag("GamePlay");
        GameObject obstacle = Instantiate(obstaclePrefab);
        Vector2 position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y);
        obstacle.transform.position = position;
        obstacle.transform.parent = gamePlay.GetComponent<Gameplay>().obstacles.transform;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.transform.position.x + Screen.width, Camera.main.transform.position.y - (Screen.height / 2)));
        if (perso.GetComponent<Perso>().plongee)
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
