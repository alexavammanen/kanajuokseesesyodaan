using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    //syökää kanaa
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }
    private float verratonpyora = 0;
    // Update is called once per frame
    void Update()
    {
        CharacterController hahmokontrolleri = GetComponent<CharacterController>();

        float horizontal = Input.GetAxis("Horizontal") * 5;
        float vertical = Input.GetAxis("Vertical") * 5;

        Vector3 nopeus = new Vector3(horizontal, 0, vertical);

       
        //hahmokontrolleri.SimpleMove(nopeus);
        hahmokontrolleri.Move(nopeus * Time.deltaTime);
        verratonpyora += Input.GetAxis("Mouse X") * 3;
        transform.localRotation = Quaternion.Euler(0, verratonpyora, 0);
        if (Input.GetAxis("Vertical") != 0)
        {
            anim.SetBool("Walk", true);
            
        }
        else
        {
            anim.SetBool("Walk", false);
        }
    }
}
