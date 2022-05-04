using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay : MonoBehaviour
{
    public Camera cameraFollow;
    public GameObject fond;
    public GameObject perso;
    public GameObject obstacles;
    public GameObject depart;
    public GameObject[] ors;
    public GameObject[] objets;
    public GameObject nbOr;
    public GameObject canvasGameOver;
    //GameOverAction
    public void GameOver()
    {
        this.perso.GetComponent<Perso>().TerminerJeu();
        this.cameraFollow.GetComponent<CameraFollow>().stop = true;
        canvasGameOver.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(this.perso.GetComponent<Perso>().DeplacementDebut());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
