using UnityEngine;
using StarterAssets;
using JetBrains.Annotations;

[DefaultExecutionOrder(-100)]
public class BougeDevantAuto : MonoBehaviour
{
    StarterAssetsInputs input;
    void Start()
    {
        input = GetComponent<StarterAssetsInputs>();
    }

    void Update()
    {
        input.move.x = Mathf.Clamp(input.move.x, -0.5f, 0.5f);
        input.move.y = 1;
        input.sprint = input.move.x != 0;
    }
}
