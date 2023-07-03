using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class papagaio : MonoBehaviour
{ 
    public float veloc = 0.0f ;

    public float entradaHorizontal;
    public float entradaVertical ;
    public GameObject Boladefogo ;
    
    public float tempoDeDisparo = 0.3f ;
    public float podeDisparar = 0.0f ;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start de "+this.name);
        veloc = 8.0f ;
        transform.position = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
     
       entradaHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*veloc*entradaHorizontal);

        if ( transform.position.x  > 0f) {
            transform.position = new Vector3(0,transform.position.y,0);
        }

        if ( transform.position.x  < -7.85f  ) {
            transform.position = new Vector3(-7.85f,transform.position.y,0);
        
        }

        
        

        entradaVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up*Time.deltaTime*veloc*entradaVertical);

        if ( transform.position.y  > 6f ) {
            transform.position = new Vector3(transform.position.x,-6f,0);
        }

        if ( transform.position.y  < -6f  ) {
            transform.position = new Vector3(transform.position.x,6f,0);
        }
        


        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)){

             if ( Time.time > podeDisparar ){
             }
                
             if (Instantiate(Boladefogo,transform.position + new Vector3(0,1.0f,0),Quaternion.identity));
               



        }








         

    } 
    



 
        













}

