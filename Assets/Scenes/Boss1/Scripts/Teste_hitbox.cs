using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste_hitbox : MonoBehaviour
{
    Collider2D m_Collider;
    // Start is called before the first frame update
    void Start()
    {
        m_Collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_Collider.enabled = !m_Collider.enabled;

            Debug.Log("Collider.enabled = " + m_Collider.enabled);
        }
    }
}
