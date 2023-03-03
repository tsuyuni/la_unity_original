using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class ItemController : MonoBehaviour
{
    Dictionary<string,bool> flags;
    public Flowchart ResultLog = null;
    // Start is called before the first frame update
    void Start()
    {
        flags = GameController.cyberRoomItemFlags;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickItem(){
        string itemName = gameObject.name;
        flags[itemName] = true;
        BagController.setItemImage();
        gameObject.SetActive(false);
    }

    public void OnClickDoor(){
        if(flags.ContainsKey("Key") && flags["Key"]){

            } else {
                ResultLog.SendFungusMessage("DoorLocked");
            }
    }


}
