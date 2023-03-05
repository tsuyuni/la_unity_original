using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed = 3;
    public GameObject camera;
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){

        if(Input.GetKey(KeyCode.W)){
            gameObject.transform.position += gameObject.transform.rotation * Vector3.forward * speed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.S)){
            gameObject.transform.position -= gameObject.transform.rotation * Vector3.forward * speed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.D)){
            gameObject.transform.position += gameObject.transform.rotation * Vector3.right * speed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.A)){
            gameObject.transform.position -= gameObject.transform.rotation * Vector3.right * speed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.UpArrow)){
            if((camera.transform.localEulerAngles.x >= 345 || camera.transform.localEulerAngles.x <= 20)){
                camera.transform.Rotate(-1, 0, 0);
            }
        }

        if(Input.GetKey(KeyCode.DownArrow)){
            if((camera.transform.localEulerAngles.x >= 340 || camera.transform.localEulerAngles.x <= 15)){
                camera.transform.Rotate(1, 0, 0);
            }
        }

        if(Input.GetKey(KeyCode.LeftArrow)){
            gameObject.transform.Rotate(0, -1, 0, Space.World);
        }

        if(Input.GetKey(KeyCode.RightArrow)){
            gameObject.transform.Rotate(0, 1, 0, Space.World);
        }



        
    }
}
