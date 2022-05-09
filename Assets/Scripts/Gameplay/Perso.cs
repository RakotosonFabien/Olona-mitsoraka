using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Perso : MonoBehaviour
{
    [Header("Game Objects")]
    public GameManager gameManager;
    
    [Header("Variables")]
    private bool enDeplacement = false;
    public bool plongee = false;
    public int ralentissement = 20;
    public void Start()
    {
    }
    //Jouer animation de plongeon atao rehefa premiere click ecran de go
    public void DebutDeplacement()
    {
        GameObject depart = GameObject.FindGameObjectWithTag("Depart");
        depart.SetActive(false);
        this.plongee = true;
        this.ChangementVDescente();
    }

    //Fin du jeu (GameOver)
    public void StopperDeplacement()
    {
        this.enDeplacement = false;
        this.gameObject.GetComponent<Rigidbody>().useGravity = false;
        this.gameObject.GetComponent<Rigidbody>().isKinematic = true;
    }

    //Changer vitesse de descente
    public void ChangementVDescente()
    {
        this.gameObject.GetComponent<Rigidbody>().drag = ralentissement;
    }
    private void Update()
    {
    }
    private void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            enDeplacement = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            enDeplacement = false;
        }
        if (enDeplacement)
        {
            Vector3 deplacement = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            float deplacementX = deplacement.x - transform.position.x;
            print("XXXXXX " + transform.position.x);
            this.transform.Translate(new Vector3(deplacementX, 0, 0));
        }
    }

    // Collision avec un obstacle
    private void Collision(Obstacle obstacle)
    {
        this.gameManager.degatManager.SimpleDegat();
        if(this.gameManager.degatManager.nombreCoups == 0)
        {
            gameManager.GameOver();
        }
    }

    // Identifier et gerer collision selon collider
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Obstacle")
        {
            this.Collision(other.GetComponent<Obstacle>());
            StartCoroutine(other.GetComponent<Obstacle>().Collision(this));
        }
        if(other.tag == "Or")
        {
            this.gameManager.orManager.AjoutOr(other.gameObject);
        }
    }
}
