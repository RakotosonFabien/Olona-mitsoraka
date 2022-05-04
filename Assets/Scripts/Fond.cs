using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fond : MonoBehaviour
{
    public Perso perso;
    public GameObject cameraFollow;
    public GameObject obstaclePrefab;
    public float timerObstacle = 0.5f;
    public Vector2 screenBounds;
    //Creation obstacle
    private void CreerObstacle()
    {
        GameObject gamePlay = GameObject.FindGameObjectWithTag("GamePlay");
        GameObject obstacle = Instantiate(obstaclePrefab);
        Vector2 position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y);
        obstacle.transform.position = position;
        obstacle.transform.parent = gamePlay.GetComponent<Gameplay>().obstacles.transform;
    }
    //tirer le fond suivant la place du perso
    public void SuivrePerso()
    {
        this.transform.position = new Vector3(this.cameraFollow.transform.position.x, this.cameraFollow.transform.position.y, this.transform.position.z);
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Camera camera = this.cameraFollow.GetComponent<Camera>();
        //screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.transform.position.x + Screen.width, this.cameraFollow.transform.position.y - (Screen.height / 2)));
        if (perso.plongee) 
        {
            this.SuivrePerso();
        }
    }
}
