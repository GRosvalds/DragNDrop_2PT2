using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour,
	IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Objekti objektuSkript;
    private CanvasGroup kanvasGroup;
    private RectTransform velkObjRectTransf;

    void Start()
    {
        kanvasGroup = GetComponent<CanvasGroup>();
        velkObjRectTransf = GetComponent<RectTransform>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        
    }

    
	
	
}
