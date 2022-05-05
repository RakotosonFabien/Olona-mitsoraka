using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Game Managers")]
    public ObstacleManager obstaclesManager;
    public DegatManager degatManager;
    public OrManager orManager;

    [Header("Game Objects")]
    public Perso perso;
    public CameraJeu cameraJeu;

    // [Header("Variables")]


    [Header("UI Elements")]
    public GameObject menu; // Bouton "Jouer" temporaire
    public Text text321;


    void Start()
    {
        menu.SetActive(true);
    }

    // OnClick du bouton Jouer
    public void CommencerJeu()
    {
        StartCoroutine(CompteARebours());
    }

    // Compte a rebours avant debut
    public IEnumerator CompteARebours()
    {
        text321.text = "3";
        yield return new WaitForSeconds(1f);
        text321.text = "2";
        yield return new WaitForSeconds(1f);
        text321.text = "1";
        yield return new WaitForSeconds(1f);
        text321.gameObject.SetActive(false);
        perso.DebutDeplacement();
    }

    // Stopper joueur, camera et afficher Ecran Game Over
    public void GameOver()
    {
        perso.StopperDeplacement();
        cameraJeu.StopFollowing(false);
        // canvasGameOver.SetActive(true);
    }
}
