using UnityEngine;

public abstract class Item : ScriptableObject {
    [SerializeField] private Sprite inventorySprite;
    [SerializeField] private string displayName;
    [SerializeField] private int shopPrice;

    public Sprite InventorySprite => inventorySprite;
    public string DisplayName => displayName;
    public int ShopPrice => shopPrice;
}
