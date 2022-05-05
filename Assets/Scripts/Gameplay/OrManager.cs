using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrManager : MonoBehaviour
{
    [Header("UI Elements")]
    public Text nombreOrUI;

    [Header("Variables")]
    public int nombreOr;

    //Ajout or
    public void AjoutOr(GameObject or)
    {
        this.nombreOr++;
        
        this.nombreOrUI.text = (nombreOr < 10) ? "0" + nombreOr : "" + nombreOr; 

        // Detruire or ajouté
        GameObject.Destroy(or);
    }
}
