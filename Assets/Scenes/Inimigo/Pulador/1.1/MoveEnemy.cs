using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public bool Walking = false;
    [SerializeField]float velocidade;

    // Update is called once per frame
    void Update()
    {
        if(Walking==true){
            transform.Translate(Vector2.right*velocidade*Time.deltaTime);
        }
    }
    
}
