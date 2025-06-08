using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Image iconImage;
    private bool isEmpty = true;

    public void SetItem(ShopItem item)
    {
        iconImage.sprite = item.itemIcon;
        iconImage.enabled = true;
        isEmpty = false;
    }

    public bool IsEmpty()
    {
        return isEmpty;
    }
}
//..