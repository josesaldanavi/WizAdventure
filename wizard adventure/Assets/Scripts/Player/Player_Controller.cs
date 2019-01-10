using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour {

    /*Boton de cambio debe ser implementado en un metodo donde lo llame un boton de la UI Boton-Player*/

    Magos Wizzard;

    [Header("Metodo de Cambio")]
    public bool swapN;
    public bool swapF = false;
    public bool swapI = false;

    [Header("Wizzard")]
    public GameObject[] wizzards;

    public void Awake()
    {

    }


    // Use this for initialization
    void Start() {
        swapN = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        if (swapN) MovimientoWizNormal();
        if (swapF) MovimientoWizFire();
        if (swapI) MovimientoWizIce();
    }


    public void MovimientoWizNormal()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if (!wizNormal.GetComponent<SpriteRenderer>().flipX)
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }
            wizNormal.transform.Translate(-speedN * Time.deltaTime, 0, 0);
            wiz_normal.SetBool("walkN", true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (wizNormal.GetComponent<SpriteRenderer>().flipX)
            {
                wizNormal.GetComponent<SpriteRenderer>().flipX = false;
            }
            wizNormal.transform.Translate(speedN * Time.deltaTime, 0, 0);
            wiz_normal.SetBool("walkN", true);
        }
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            wiz_normal.SetBool("walkN", false);
        }
    }


    public void MovimientoWizFire()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if (!wizFire.GetComponent<SpriteRenderer>().flipX)
            {
                wizFire.GetComponent<SpriteRenderer>().flipX = true;
            }
            wizFire.transform.Translate(-speedF * Time.deltaTime, 0, 0);
            wiz_fire.SetBool("walkF", true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (wizFire.GetComponent<SpriteRenderer>().flipX)
            {
                wizFire.GetComponent<SpriteRenderer>().flipX = false;
            }
            wizFire.transform.Translate(speedF * Time.deltaTime, 0, 0);
            wiz_fire.SetBool("walkF", true);
        }
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            wiz_fire.SetBool("walkF", false);
        }
    }

    public void MovimientoWizIce()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if (!wizIce.GetComponent<SpriteRenderer>().flipX)
            {
                wizIce.GetComponent<SpriteRenderer>().flipX = true;
            }
            wizIce.transform.Translate(-speedI * Time.deltaTime, 0, 0);
            wiz_ice.SetBool("walkI", true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (wizIce.GetComponent<SpriteRenderer>().flipX)
            {
                wizIce.GetComponent<SpriteRenderer>().flipX = false;
            }
            wizIce.transform.Translate(speedI * Time.deltaTime, 0, 0);
            wiz_ice.SetBool("walkI", true);
        }
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            wiz_ice.SetBool("walkI", false);
        }
    }

    public void ActiveSwapNormal()
    {
        if (Input.GetKey(KeyCode.N))
        {
            swapN = true;
        }
        else swapN = false;

    }

    public void ActiveSwapFire()
    {
        if (Input.GetKey(KeyCode.F))
        {
            swapF = true;
        }
        else swapF = false;
    }

    public void ActiveSwapIce()
    {
        if (Input.GetKey(KeyCode.I))
        {
            swapI = true;
        }
        else swapF = false;
    }

    public enum Magos
    {
        fire,
        ice,
        normal,
     } 

}
/* hacer que las animaciones cambien dependiendo del bool que tengan, digamos que el wF esta activo y esta en la animación de idle
 * y de ahi tiene que pasar al wI, entonces tenemos que poner una condicion que diga que si esta activo el wF o WI o WN , cuando aprete el
 * boton de swap (cambio) que aparezca el mago elegido- --> hacer 3 botones de cambio  y que aparezca uno trasta otro dependiendo el mago que
 estas utliziando */