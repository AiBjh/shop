using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;

    public List<InventorySlot> slots; // Inspector에 슬롯들 연결

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void AddItem(ShopItem item)
    {
        if (slots == null)
        {
            Debug.LogError("slots 리스트가 null입니다!");
            return;
        }

        for (int i = 0; i < slots.Count; i++)
        {
            if (slots[i] == null)
            {
                Debug.LogError("slots[" + i + "] 가 null입니다!");
                continue;
            }

            if (slots[i].IsEmpty())
            {
                slots[i].SetItem(item);
                return;
            }
        }

        Debug.Log("인벤토리가 가득 찼습니다.");
    }

}
