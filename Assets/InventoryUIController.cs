using UnityEngine;

public class InventoryUIManager : MonoBehaviour
{
    public GameObject inventoryPanel;

    void Update() //.
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            ToggleInventory();
        }
    }

    public void ToggleInventory()
    {
        if (inventoryPanel.activeSelf)
            inventoryPanel.SetActive(false);
        else
            inventoryPanel.SetActive(true);
    }
}
