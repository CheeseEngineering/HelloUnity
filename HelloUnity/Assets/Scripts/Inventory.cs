using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<GameObject> itemGos;
    private void Awake()
    {
        Debug.Log($"{itemGos.Count}");
        // itemGos�� ��ȸ�ϸ鼭 �����۵��� �̸��� ����ϰ� �ʹ�.
 
        for(int i=0; i<this.itemGos.Count; i++)
        {

            GameObject itemGo = this.itemGos[i];
            Item item = itemGo.GetComponent<Item>();
            Debug.Log($"������ �̸� : {item.itemName}");
            
        }

        // ���
        // �ܰ�
        // Ȱ

    }
}
