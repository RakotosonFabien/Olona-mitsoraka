using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NbCoup : MonoBehaviour
{
    public int nbCoups;
    public void SimpleDegat()
    {
        this.changerNbCoups(this.nbCoups - 1);
    }
    //
    void changerNbCoups(int nouveau)
    {
        this.nbCoups = nouveau;
        this.GetComponent<Text>().text = System.Convert.ToString(nbCoups);
    }
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Text>().text = System.Convert.ToString(nbCoups);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
