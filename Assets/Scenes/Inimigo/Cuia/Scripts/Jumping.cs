using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Rigidbody2D rigidBody;
    void Start()
    {
        RandomNumber();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void RandomNumber(){
        var numero= Random.Range(0.0f, 9.0f);
        if(numero>3){
            rigidBody.AddForce(new Vector2(0,35f), ForceMode2D.Impulse);
        }
        StartCoroutine(Waiting());
    }IEnumerator Waiting()
    {
        yield return new WaitForSeconds(1);
        RandomNumber();
    }
}
