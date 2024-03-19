using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonAudio : MonoBehaviour
{
    public AudioClip audioClip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ReproducirAudio();
    }

    public void ReproducirAudio()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //Debug.DrawRay(ray.origin, ray.direction, Color.blue, 4);

            RaycastHit infoRayo;

            if (Physics.Raycast(ray, out infoRayo))
            {
                if (infoRayo.collider == GetComponent<Collider>())
                {
                    AudioSource.PlayClipAtPoint(audioClip, transform.position);
                    //Debug.Log("reproduciendo audio");
                }


            }


        }

    }
}
