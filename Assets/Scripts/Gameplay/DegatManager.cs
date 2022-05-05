using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DegatManager : MonoBehaviour
{
    [Header("UI Elements")]
    public Text nombreCoupUI;

    [Header("Variables")]
    public int nombreCoups;

    private void Start() 
    {
        nombreCoups = 6;
        nombreCoupUI.text = "6";
    }

    public void SimpleDegat()
    {
        this.ModifierNombreCoup(- 1);
    }

    // Incrementer ou Decrementer le nombre de coup
    private void ModifierNombreCoup(int valeur)
    {
        this.nombreCoups = this.nombreCoups + valeur;
        this.nombreCoupUI.text = System.Convert.ToString(nombreCoups);
    }
}
