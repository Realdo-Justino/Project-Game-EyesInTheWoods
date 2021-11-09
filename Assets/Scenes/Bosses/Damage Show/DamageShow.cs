using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageShow : MonoBehaviour
{
    // Start is called before the first frame update
    SpriteRenderer m_SpriteRenderer;
    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowDamage(){
        StartCoroutine(Dano());
    }
    IEnumerator Dano()
    {
        m_SpriteRenderer.color = Color.red;
        yield return new WaitForSeconds(0.2f);
        m_SpriteRenderer.color = Color.white;
    }
}
