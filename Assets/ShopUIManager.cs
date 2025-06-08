using UnityEngine;
using UnityEngine.UI;

public class ShopUIManager : MonoBehaviour
{
    public GameObject shopPanel;
    public ShopItem[] items; // Inspector���� ���
    public Button[] buyButtons; // Inspector���� ���

    
    
        void Start()
        {
            if (buyButtons == null || buyButtons.Length == 0)
            {
                Debug.LogError(" buyButtons �迭�� null�̰ų� ��� �ֽ��ϴ�.");
                return;
            }

            for (int i = 0; i < buyButtons.Length; i++)
            {
                if (buyButtons[i] == null)
                {
                    Debug.LogError($" buyButtons[{i}] �� null�Դϴ�.");
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
        Debug.Log("������ ������: " + items[index].itemName);
        InventoryManager.Instance.AddItem(items[index]);
    }






    //.
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))  // S Ű�� ������ ��
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
