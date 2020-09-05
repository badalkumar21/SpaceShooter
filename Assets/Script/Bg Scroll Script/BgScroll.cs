using UnityEngine;

public class BgScroll : MonoBehaviour
{
    public float scrollSpeed = 0.1f;
    private MeshRenderer _meshRenderer;
    private float _xScroll;


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
        _xScroll = Time.time * scrollSpeed;
        
        Vector2 offSet = new Vector2(0f,_xScroll);
        _meshRenderer.sharedMaterial.SetTextureOffset("_MainTex",offSet);
        
    }
}