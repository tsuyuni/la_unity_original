using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotController : MonoBehaviour
{
    public GameObject slot;
    public GameObject image;
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }

    public void SelectItem(){
        slot.GetComponent<Outline>().enabled = true;
        ItemController.selectedItem = image.tag;
    }

    public void OnClickSlot(){
        if(image.GetComponent<Image>().sprite != null){
            // Debug.Log(image.GetComponent<Image>().sprite);
            SelectItem();
        }
    }
}
