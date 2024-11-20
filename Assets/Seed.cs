using UnityEngine;

[CreateAssetMenu]
public class Seed : Item
{
    [SerializeField] private int growthDuration;
    [SerializeField] private Plant associatedPlant;

    public int GrowthDuration => growthDuration;
    public Plant AssociatedPlant => associatedPlant;
}