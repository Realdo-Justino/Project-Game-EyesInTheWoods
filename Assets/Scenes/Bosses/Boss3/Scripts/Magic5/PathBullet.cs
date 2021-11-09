using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathBullet : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    void Start()
    {
        rb.AddForce(new Vector2(-10f,0f), ForceMode2D.Impulse);
        Up();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Up(){
        rb.AddForce(new Vector2(0f,20f), ForceMode2D.Impulse);
        StartCoroutine(WaitingTimeUp());
    }
    void Down(){
        rb.AddForce(new Vector2(0f,-20f), ForceMode2D.Impulse);
        StartCoroutine(WaitingTimeDown());

    }
    IEnumerator WaitingTimeUp(){
        yield return new WaitForSeconds(0.5f);
        rb.AddForce(new Vector2(0f,-20f), ForceMode2D.Impulse);
        Down();
    }
    IEnumerator WaitingTimeDown(){
        yield return new WaitForSeconds(0.5f);
        rb.AddForce(new Vector2(0f,20f), ForceMode2D.Impulse);
        Up();
    }

}
