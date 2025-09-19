using UnityEngine;

public class MaterialManager : MonoBehaviour
{
    public static MaterialManager Instance { get; private set; }

    [Header("Assign in Inspector")]
    [SerializeField] private Material hitMaterial1;
    [SerializeField] private Material hitMaterial2;

    public static Material Hit1 => Instance.hitMaterial1;
    public static Material Hit2 => Instance.hitMaterial2;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}