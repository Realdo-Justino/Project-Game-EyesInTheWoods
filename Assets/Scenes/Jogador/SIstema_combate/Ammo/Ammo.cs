using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite[] spriteArray;
    public SpriteRenderer spriteRenderer;
    Arma Arma;
    FireWeapon2 FireWeapon2;
    Weapon2 Weapon2;
    [SerializeField]int Municao;
    void Start()
    {
        Arma=GameObject.Find("Jogador").GetComponent<Arma>();
        FireWeapon2=GameObject.Find("Jogador").GetComponent<FireWeapon2>();
        Weapon2=GameObject.Find("Jogador").GetComponent<Weapon2>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Arma.WActivated){
            Municao=Arma.municao;
        }
        if(Weapon2.WActivated){
            Municao=FireWeapon2.municao;
        }
        spriteRenderer.sprite = spriteArray[Municao];
    }
}
