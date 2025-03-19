using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        
    }

    public void playerAttack()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ani.SetTrigger("attack");
        }
    }
}
