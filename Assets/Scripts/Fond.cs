using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fond : MonoBehaviour
{
    public Perso perso;
    public CameraFollow cameraFollow;
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
        if (perso.plongee)
        {
            this.SuivrePerso();
        }
    }
}
