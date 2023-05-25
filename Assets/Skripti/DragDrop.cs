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
        objektuSkript.pedejaisVilktais = null;
        kanvasGroup.alpha = 0.6f;
        kanvasGroup.blocksRaycasts= false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        velkObjRectTransf.anchoredPosition += eventData.delta / objektuSkript.kanva.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        objektuSkript.pedejaisVilktais = eventData.pointerDrag;
        kanvasGroup.alpha = 1f;

        if (objektuSkript.vaiIstajaVieta == false)
            kanvasGroup.blocksRaycasts = true;

        else
            objektuSkript.pedejaisVilktais = null;
        objektuSkript.vaiIstajaVieta= false;
    }

    
	
	
}
