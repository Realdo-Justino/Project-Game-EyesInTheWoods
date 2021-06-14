using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidade=20f;
    public Rigidbody2D rb;

    public bool atirando;
    

    //Variavel para chamda futura da vida do inimigo
    Vida_Inimigo inimigo;

    void Start(){
        rb.velocity=transform.right*velocidade;
    }
    private void OnTriggerEnter2D(Collider2D colisor) {
        Debug.Log(colisor.gameObject.tag);
        if(colisor.gameObject.tag!="Map"){
             Destroy(GameObject.FindWithTag("Projeteis"));
        }
    }
}