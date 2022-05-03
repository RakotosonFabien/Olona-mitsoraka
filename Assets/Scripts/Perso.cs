using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Perso : MonoBehaviour
{
    private bool enDeplacement = false;
    public bool plongee = false;
    public float deplacementSpeed;
    public GameObject nbCoups;
    public GameObject nbOrs;
    //Ajout or
    public void AjoutOr()
    {
        this.nbOrs.GetComponent<NbOr>().nombreOr++;
        this.nbOrs.GetComponent<NbOr>().nbOr.GetComponent<Text>().text = System.Convert.ToString(this.nbOrs.GetComponent<NbOr>().nombreOr);
    }
    //Fin de jeu
    public void TerminerJeu()
    {
        this.enDeplacement = false;
        this.gameObject.GetComponent<Rigidbody>().useGravity = false;
    }
    //Effet collision
    private void Collision(Obstacle obstacle)
    {
        this.nbCoups.GetComponent<NbCoup>().SimpleDegat();
        if(this.nbCoups.GetComponent<NbCoup>().nbCoups == 0)
        {
            GameObject.FindGameObjectWithTag("GamePlay").GetComponent<Gameplay>().GameOver();
        }
    }
    //Mouvement debut de jeu du perso, se deplace de gauche a droite
    public IEnumerator DeplacementDebut()
    {
        GameObject textGO = GameObject.FindGameObjectWithTag("CompteDebutJeu");
        Text texte = textGO.GetComponent<Text>();
        texte.text = "3";
        yield return new WaitForSeconds(1f);
        texte.text = "2";
        yield return new WaitForSeconds(1f);
        texte.text = "1";
        yield return new WaitForSeconds(1f);
        textGO.SetActive(false);
        Debut();
        plongee = true;
    }
    //Jouer animation de plongeon atao rehefa premiere click ecran de go
    private void Debut()
    {
        GameObject depart = GameObject.FindGameObjectWithTag("Depart");
        depart.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
       // StartCoroutine(DeplacementDebut());
        
    }

    // Update is called once per frame
    void Update()
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
            this.transform.Translate(new Vector3(deplacementX, 0, 0));
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Obstacle")
        {
            this.Collision(other.GetComponent<Obstacle>());
            StartCoroutine(other.GetComponent<Obstacle>().Collision(this));
        }
        if(other.tag == "Or")
        {
            print("DE L'OR DE L'OR");
            this.AjoutOr();
            other.GetComponent<Or>().DejaAjoute();
        }
    }
}
