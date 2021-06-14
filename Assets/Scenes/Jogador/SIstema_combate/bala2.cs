using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala2 : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidade=20f;
    public Rigidbody2D rb;

    public bool atirando;
    private int dano=1;
    Vida_Inimigo inimigo;

    void Start(){
        rb.velocity=transform.right*velocidade;
        inimigo = gameObject.transform.parent.gameObject.GetComponent<Vida_Inimigo>();
    }
    private void OnTriggerEnter2D(Collider2D colisor) {
        Vida_Inimigo enemy=colisor.GetComponent<Vida_Inimigo>();
        if((enemy !=null)&&(atirando==true)){
            colisor.gameObject.GetComponent<Vida_Inimigo>().receberDano(dano);
        }
        Destroy(GameObject.FindWithTag("Projeteis"));
    }
}
