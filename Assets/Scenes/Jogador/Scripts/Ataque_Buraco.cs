using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataque_Buraco : MonoBehaviour
{
    public Game_Over Game_Over;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D colisor) {
        if(colisor.gameObject.CompareTag("Player")){
            //Se o personagem tocar a hitbox invisivel do buraco, causa o gameover
            Destroy(GameObject.FindWithTag("Player"));
            Game_Over.Setup();
        }
        
    }
}
