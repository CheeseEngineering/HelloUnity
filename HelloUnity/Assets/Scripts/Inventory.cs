using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<GameObject> itemGos;
    private void Awake()
    {
        Debug.Log($"{itemGos.Count}");
        // itemGos를 순회하면서 아이템들의 이름을 출력하고 싶다.
 
        for(int i=0; i<this.itemGos.Count; i++)
        {

            GameObject itemGo = this.itemGos[i];
            Item item = itemGo.GetComponent<Item>();
            Debug.Log($"아이템 이름 : {item.itemName}");
            
        }

        // 장검
        // 단검
        // 활

    }
}
