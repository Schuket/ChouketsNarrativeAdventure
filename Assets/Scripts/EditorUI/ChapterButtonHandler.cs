using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RectTransform))]
public class ChapterButtonHandler : MonoBehaviour
{
    RectTransform m_rectTransform;
    [SerializeField] GameObject m_chapterButtonPrefab;
    [SerializeField] Button m_addChapterButton;

    Vector3 m_initialPos;
    float m_chapterButtonWidth;


    // Start is called before the first frame update
    void Start()
    {
        m_rectTransform = GetComponent<RectTransform>();
        m_initialPos = m_rectTransform.localPosition;
        Debug.Log(m_initialPos.x);
        Initialize(); // Remove when project loading as beeen done.
    }

    public void Initialize()
    {
        GameObject newChapterButton = CreateNewChapterButton();
        m_chapterButtonWidth = newChapterButton.GetComponent<RectTransform>().sizeDelta.x;

    }

    public GameObject CreateNewChapterButton()
    {
        GameObject newChapterButton = Instantiate<GameObject>(m_chapterButtonPrefab);

        newChapterButton.transform.SetParent(transform);
        m_addChapterButton.transform.SetAsLastSibling();

        return newChapterButton;
    }

    public void AddNewChapterButton()
    {
        GameObject newChapterButton = CreateNewChapterButton();
    }

    public void SlideLeft()
    {
        float newXpos = m_rectTransform.localPosition.x + m_chapterButtonWidth;
        Debug.Log(newXpos);
        Debug.Log(m_initialPos.x);
        if (newXpos > m_initialPos.x)
            return;

        m_rectTransform.localPosition = new Vector2(newXpos, m_initialPos.y);
    }

    public void SlideRight()
    {
        float newXpos = m_rectTransform.localPosition.x - m_chapterButtonWidth;
        float chapterButtonWidthTotal = m_chapterButtonWidth * transform.childCount;
        
        if (chapterButtonWidthTotal < Screen.width)// Can slide only when Header is Full
            return;
        if (newXpos < -1f * (chapterButtonWidthTotal - Screen.width)) // Can slide only until one slot is empty
            return;

        m_rectTransform.localPosition = new Vector2(newXpos, m_initialPos.y);
    }

    // Initialize(Project) => Load enough button to correspond to loaded project


}
