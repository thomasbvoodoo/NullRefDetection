using UnityEngine;

[CreateAssetMenu(fileName = "some_data", menuName = "Data/Some")]
public class SomeData : ScriptableObject
{
    [SerializeField] private GameObject masterPrefab = null;
    [SerializeField] private GameObject variantFromMaster = null;
    [SerializeField] private GameObject variantCopy1 = null;
    [SerializeField] private GameObject variantCopy2 = null;
    [SerializeField] private GameObject variantCopy3 = null;
    [SerializeField] private GameObject masterPrefabCopy = null;
    [SerializeField] private GameObject otherVariantFromMaster = null;
}
