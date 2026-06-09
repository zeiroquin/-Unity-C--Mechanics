using UnityEngine;
using System.Collections.Generic; // Нужно для работы со списками List

public class InventorySystem : MonoBehaviour
{
    // Динамический список для хранения названий предметов
    [SerializeField] private List<string> items = new List<string>();

    // Метод добавления предмета в инвентарь
    public void AddItem(string itemName)
    {
        items.Add(itemName);
        Debug.Log(itemName + " добавлен в инвентарь.");
    }

    // Метод удаления предмета
    public bool RemoveItem(string itemName)
    {
        if (items.Contains(itemName))
        {
            items.Remove(itemName);
            Debug.Log(itemName + " удален из инвентаря.");
            return true;
        }
        
        Debug.Log("Предмет " + itemName + " не найден.");
        return false;
    }

    // Проверка, есть ли предмет у игрока (например, ключ)
    public bool HasItem(string itemName)
    {
        return items.Contains(itemName);
    }
}
