using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    // Start is called before the first frame update
    //Criação do local de spawn das balas em relação ao personagem
    public Transform Firepoint;

    public bool inicio=false;

    //Referencia aos scripts da programação da bala
    public bala Projetil;

    public int municao=6;

    //Chamada o objeto que atua como a bala
    public GameObject bulletPrefab;

    // Update is called once per frame

    void Update()
    {
        //Se o jogo tiver iniciado, o personagem ter munição e houve um input de tiro, realize a progrmação de tiro
        if((Input.GetButtonDown("Fire1"))&&(municao>0)){
            atirar();
            Projetil.atirando=true;
        }
        //Sistema de recarga da munição
        if(Input.GetButtonDown("Fire3")){
            municao=6;
        }
    }
    void atirar(){
        municao-=1;
        //Inicia trajetoria da bala em relação ao personagem principal
        Instantiate(bulletPrefab,Firepoint.position,Firepoint.rotation);
        Projetil.atirando=false;
    }

}
