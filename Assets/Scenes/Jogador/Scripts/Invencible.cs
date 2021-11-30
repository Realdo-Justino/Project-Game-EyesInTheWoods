using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invencible : MonoBehaviour
{
    // Start is called before the first frame update
    Vida_personagem_principal Vida_personagem_principal;
    void Start()
    {
        Vida_personagem_principal= GetComponent<Vida_personagem_principal>();
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown((KeyCode.P))){
            Vida_personagem_principal.Cheat=!Vida_personagem_principal.Cheat;
        }
    }
}
