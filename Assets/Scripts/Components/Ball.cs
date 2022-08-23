using UnityEngine;

public class Ball : MonoBehaviour
{
    public static Ball Instance;

    private void Awake()
    {
        Instance = this;
    }
}
