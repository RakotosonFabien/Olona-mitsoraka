using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fond : MonoBehaviour
{
    [Header("Game Objects")]
    public GameManager gameManager;

    //tirer le fond suivant la place du perso
    public void SuivrePerso()
    {
        this.transform.position = new Vector3(gameManager.cameraJeu.transform.position.x, gameManager.cameraJeu.transform.position.y, this.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        //Camera camera = this.cameraFollow.GetComponent<Camera>();
        //screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.transform.position.x + Screen.width, gameManager.cameraFollow.transform.position.y - (Screen.height / 2)));
        if (gameManager.perso.plongee) 
        {
            this.SuivrePerso();
        }
    }
}
