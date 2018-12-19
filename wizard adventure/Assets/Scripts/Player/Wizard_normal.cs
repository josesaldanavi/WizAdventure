using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard_normal : MonoBehaviour {
    public Animator wiz_normal;

    public void Movimiento()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if (GetComponent<SpriteRenderer>().flipX)
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }
            transform.Translate(-1.5f * Time.deltaTime, 0, 0);
            wiz_normal.SetBool("walk", true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (!GetComponent<SpriteRenderer>().flipX)
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }
            transform.Translate(1.5f * Time.deltaTime, 0, 0);
            wiz_normal.SetBool("walk", true);
        }
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            wiz_normal.SetBool("walk", false);
        }
    }
}
