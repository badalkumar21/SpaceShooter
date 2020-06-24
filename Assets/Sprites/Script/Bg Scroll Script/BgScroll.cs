using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgScroll : MonoBehaviour
{
    public float scrollSpeed = 0.1f;
    private MeshRenderer _meshRenderer;
    private float x_scroll;


    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Scroll();
    }

    void Scroll()
    {
        x_scroll = Time.time * scrollSpeed;
        
        Vector2 offSet = new Vector2(x_scroll,0f);
        _meshRenderer.sharedMaterial.SetTextureOffset("_MainTex",offSet);
        
    }
}