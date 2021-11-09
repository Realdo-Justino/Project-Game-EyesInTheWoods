using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackFall : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]Rigidbody2D rigidBody;
    float posicaox;
    float posicaoy;
    void Start()
    {
        posicaox=transform.position.x;
        posicaoy=transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeGravity(){
        rigidBody.gravityScale=10;
    }
    public void ChangeBack(){
        rigidBody.gravityScale=0;
        transform.position = new Vector3(posicaox, posicaoy);
    }
}
