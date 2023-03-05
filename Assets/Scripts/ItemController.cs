using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class ItemController : MonoBehaviour
{
    public static string selectedItem;
    public Flowchart ResultLog = null;
    public GameObject door;
    // Start is called before the first frame update
    void Start(){
    }

    // Update is called once per frame
    void Update(){ 
    }

    public void OnClickItem(){
        BagController.SetItemImage(gameObject.tag);
        gameObject.SetActive(false);
    }

    public void OnClickDoor(){
        if(selectedItem != null && selectedItem == "Key"){
            OpenDoor();
            } else {
                ResultLog.SendFungusMessage("DoorLocked");
            }
    }

    void OpenDoor(){
        door.GetComponent<Animation>().Play();
        Debug.Log("Open");
    }


}
