using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageAcctivar2 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Collider2D Dano;
    [SerializeField] Magic4 Magic4;
    [SerializeField]SpriteRenderer m_SpriteRenderer;
    void Start()
    {
        m_SpriteRenderer.enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Begining(){
        StartCoroutine(Showing());
    }
    IEnumerator Waiting(){
        Dano.enabled =true;
        yield return new WaitForSeconds(4);
        Return();
    }
     void Return(){
        Magic4.Comeback();
        m_SpriteRenderer.enabled=false;
        Dano.enabled =false;
    }
    IEnumerator Showing(){
        m_SpriteRenderer.enabled=true;
        yield return new WaitForSeconds(1);
        Meio();
    }
    void Meio(){
        StartCoroutine(Waiting());
    }
}
