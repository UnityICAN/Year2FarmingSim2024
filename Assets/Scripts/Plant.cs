using UnityEngine;

[CreateAssetMenu]
public class Plant : Item
{
    [SerializeField] private int salePrice;

    public int SalePrice => salePrice;
}