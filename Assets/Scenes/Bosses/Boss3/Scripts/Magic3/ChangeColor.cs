using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    // Start is called before the first frame update
    SpriteRenderer m_SpriteRenderer;
    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_SpriteRenderer.enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeTrue(){
        m_SpriteRenderer.enabled=true;
    }
    public void ChangeFalse(){
        m_SpriteRenderer.enabled=false;
    }
    public void ChangeColorSprite(){
        m_SpriteRenderer.color = Color.red;
    }
}
