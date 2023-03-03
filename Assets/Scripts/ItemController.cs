using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickItem(){
        string itemName = gameObject.name;
        GameController.cyberRoomItemFlags[itemName] = true;
        BagController.setItemImage();
        gameObject.SetActive(false);
    }
}
