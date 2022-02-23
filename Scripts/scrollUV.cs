using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollUV : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector2 offset;
    private Material mat;
    [SerializeField] private float parallax;
    void Start()
    {
        mat = GetComponent<MeshRenderer>().material;
        offset = mat.mainTextureOffset;
    }
    
    void FixedUpdate()
    {
        offset.x = transform.position.x / transform.localScale.x / parallax;
        offset.y = transform.position.y / transform.localScale.y / parallax;
        mat.mainTextureOffset = offset;
    }
}
