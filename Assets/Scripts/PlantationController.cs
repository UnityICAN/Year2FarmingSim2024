using UnityEngine;

public class PlantationController : MonoBehaviour
{
    private Seed sowedSeed;
    public bool HasSeed => sowedSeed != null;

    public void HandleSowing(Seed seedToSow)
    {
        sowedSeed = seedToSow;
        Debug.Log("seedSowed!");
    }
}
