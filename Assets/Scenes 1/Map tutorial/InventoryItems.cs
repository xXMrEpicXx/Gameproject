using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventoryItems : MonoBehaviour, IBeginDragHandler,IDragHandler, IEndDragHandler
{
    public UnityEngine.UI.Image image;
    public Transform parentAfterDrag;
    public void OnBeginDrag(PointerEventData eventData)
    {
        image.raycastTarget = false;
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        image.raycastTarget  = true;
        transform.SetParent(parentAfterDrag);
        //transform.position = parentAfterDrag.position;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
