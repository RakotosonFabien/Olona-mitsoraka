using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    //Collision avec perso
    public IEnumerator Collision(Perso perso)
    {
        this.GetComponent<SpriteRenderer>().color = Color.red;
        yield return new WaitForSeconds(1f);
        GameObject.Destroy(this.gameObject);
    }
}
