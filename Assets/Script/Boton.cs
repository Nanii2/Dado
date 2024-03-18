using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton : MonoBehaviour
{
    public ParticleSystem particulas;
    private bool particlesEnabled = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))  PulsacionJugador(); 
    }

    public void PulsacionJugador()
    {

        //me guardo un ray entre la camara y la posicion del reaton
        // esto lo hago con el metodo screenpointtoray de la camara
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //Debug.DrawRay(ray.origin, ray.direction, Color.red, 4);

        RaycastHit infoRayo;

        if (Physics.Raycast(ray, out infoRayo))
        {
            if (infoRayo.transform.tag == "boton")
            {
                particlesEnabled = !particlesEnabled;

                //he chocado con el boton reset
                if (particlesEnabled)
                {
                    particulas.Play();

                }
                else
                {

                    particulas.Stop();
                }
                
            }
           


        }

    }


}
