using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour {
    [Header ("WizNormal") ]
    public Animator wiz_normal;
    public Sprite wiz_IdleN;
    public float speedN;
    public bool activeWN;


    [Header("WizIce")]
    public Animator wiz_ice;
    public Sprite wiz_IdleI;
    public float speedI;
    public bool activeWI;

    [Header("WizFire")]
    public Animator wiz_fire;
    public Sprite wiz_IdleF;
    public float speedF;
    public bool activeWF;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        
    }

    private void FixedUpdate()
    {
        MovimientoWizNormal();
    }


    public void MovimientoWizNormal()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if (!GetComponent<SpriteRenderer>().flipX)
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }
            transform.Translate(-speedN * Time.deltaTime, 0, 0);
            wiz_normal.SetBool("walkN", true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (GetComponent<SpriteRenderer>().flipX)
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }
            transform.Translate(speedN * Time.deltaTime, 0, 0);
            wiz_normal.SetBool("walkN", true);
        }
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            wiz_normal.SetBool("walkN", false);
        }
    }

}
/* hacer que las animaciones cambien dependiendo del bool que tengan, digamos que el wF esta activo y esta en la animación de idle
 * y de ahi tiene que pasar al wI, entonces tenemos que poner una condicion que diga que si esta activo el wF o WI o WN , cuando aprete el
 * boton de swap (cambio) que aparezca el mago elegido- --> hacer 3 botones de cambio  y que aparezca uno trasta otro dependiendo el mago que
 estas utliziando */