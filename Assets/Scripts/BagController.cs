using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BagController : MonoBehaviour
{

    public static List<GameObject> possessingItems = new List<GameObject>();
    public GameObject itemList;
    public GameObject[] slots;
    public static GameObject[] staticSlots;
    public Sprite sourseSprite;
    public static Sprite staticSourseSprite;
    // Start is called before the first frame update
    void Start()
    {
        staticSlots = slots;
        staticSourseSprite = sourseSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickBag(){
        itemList.SetActive(!itemList.activeSelf);
    }

    public static void setItemImage(){
        foreach(GameObject slot in staticSlots){
            Image image = slot.GetComponent<Image>();
            if(image.sprite == null){
                image.sprite = staticSourseSprite;
                image.color = new Color32(255,255,255,255);
                break;
            }
        }
    }
}
