using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Perso : MonoBehaviour
{
    private bool enDeplacement = false;
    public bool plongee = false;
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
}
