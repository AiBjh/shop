using UnityEngine;
using UnityEngine.UI;

public class ShopUIManager : MonoBehaviour
{
    public GameObject shopPanel;
    public ShopItem[] items; // Inspector에서 등록
    public Button[] buyButtons; // Inspector에서 등록

    
    
        void Start()
        {
            if (buyButtons == null || buyButtons.Length == 0)
            {
                Debug.LogError(" buyButtons 배열이 null이거나 비어 있습니다.");
                return;
            }

            for (int i = 0; i < buyButtons.Length; i++)
            {
                if (buyButtons[i] == null)
                {
                    Debug.LogError($" buyButtons[{i}] 가 null입니다.");
                    continue;
                }

                int index = i;
                buyButtons[i].onClick.AddListener(() => BuyItem(index));
            }
        }

    

    public void ShowShop()
    {
        shopPanel.SetActive(true);
    }

    public void HideShop()
    {
        shopPanel.SetActive(false);
    }

    void BuyItem(int index)
    {
        Debug.Log("구매한 아이템: " + items[index].itemName);
        InventoryManager.Instance.AddItem(items[index]);
    }






    //.
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))  // S 키를 눌렀을 때
        {
            ToggleShop();
        }
    }

    void ToggleShop()
    {
        if (shopPanel.activeSelf)
        {
            HideShop();
        }
        else
        {
            ShowShop();
        }
    }

}
