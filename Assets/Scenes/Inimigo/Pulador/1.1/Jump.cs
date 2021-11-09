using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Vision Vision;
    Rigidbody2D rb;
    [SerializeField] public float pulo;
    [SerializeField] FlipEnemy FlipEnemy;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }
    public void Jumping(){
        pulo=Vision.pulo;
        if(pulo>0){
            FlipEnemy.FlipRight();
        }else FlipEnemy.FlipLeft();
        rb.AddForce(new Vector2(pulo,10f), ForceMode2D.Impulse);
    }
}
