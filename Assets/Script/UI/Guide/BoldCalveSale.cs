using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

/// <summary>
/// ���������ο�
/// </summary>
public class BoldCalveSale : MonoBehaviour
{
    public static BoldCalveSale instance;
[UnityEngine.Serialization.FormerlySerializedAs("Hand")]    public GameObject Lung;
[UnityEngine.Serialization.FormerlySerializedAs("TextBg")]    public GameObject MineDy;
[UnityEngine.Serialization.FormerlySerializedAs("target")]
    /// <summary>
    /// ������ʾĿ��
    /// </summary>
    public GameObject Ashore;
[UnityEngine.Serialization.FormerlySerializedAs("Text")]
    public Text Mine;
    /// <summary>
    /// ����Χ����
    /// </summary>
    private Vector3[] Trapper= new Vector3[4];
    /// <summary>
    /// �ο���������
    /// </summary>
    private Vector4 Burial;
    /// <summary>
    /// ���յ�ƫ��x
    /// </summary>
    private float AshoreThirtyX= 0;
    /// <summary>
    /// ���յ�ƫ��y
    /// </summary>
    private float AshoreThirtyY= 0;
    /// <summary>
    /// ���ֲ���
    /// </summary>
    private Material Eminence;
    /// <summary>
    /// ��ǰ��ƫ��x
    /// </summary>
    private float BluefinThirtyX= 0f;
    /// <summary>
    /// ��ǰ��ƫ��y
    /// </summary>
    private float BluefinThirtyY= 0f;
    /// <summary>
    /// �����������ŵĶ���ʱ��
    /// </summary>
    private float SmoothThey= 0.1f;
    /// <summary>
    /// �¼���͸���
    /// </summary>
    private LibelousBisonAmbitious MapleAmbitious;

    private void Awake()
    {
        instance = this;
    }
[UnityEngine.Serialization.FormerlySerializedAs("Currentindex")]
    public int Encyclopedia;

    public void FairCalve(GameObject _target, string text)
    {
        if (_target == null)
        {
            Lung.SetActive(false);
            if (Eminence == null)
            {
                Eminence = GetComponent<Image>().material;
            }
            Eminence.SetVector("_Center", new Vector4(0, 0, 0, 0));
            Eminence.SetFloat("_SliderX", 0);
            Eminence.SetFloat("_SliderY", 0);
            // ���û��target�������������ر�����
            GetComponent<Button>().onClick.AddListener(() =>
            {
                //UserGuideManager.instance.FinishUserGuide();
            });
        }
        else
        {
            DOTween.Kill("NewUserHandAnimation");
            Wool(_target);
            GetComponent<Button>().onClick.RemoveAllListeners();
        }

        if (!string.IsNullOrEmpty(text))
        {
            Mine.text = text;

            Mine.transform.parent.gameObject.SetActive(true);
            var pos = Lung.transform.localPosition;
            //TextBg.transform.localPosition = new Vector3(pos.x, pos.y + 400, 0);
        }
        else
        {
            Mine.transform.parent.gameObject.SetActive(false);
        }
    }


    public void Wool(GameObject _target)
    {
        this.Ashore = _target;

        MapleAmbitious = GetComponent<LibelousBisonAmbitious>();
        if (MapleAmbitious != null)
        {
            MapleAmbitious.MadKettleSlice(_target.GetComponent<Image>());
        }

        Canvas canvas = UIInject.LawFigurine().WarmGenius.GetComponent<Canvas>();

        //��ȡ����������ĸ��������������
        if (Ashore.GetComponent<RectTransform>() != null)
        {
            Ashore.GetComponent<RectTransform>().GetWorldCorners(Trapper);
        }
        else
        {
            Vector3 pos = Camera.main.WorldToScreenPoint(_target.transform.position);
            pos = UIInject.LawFigurine().UIFollow.GetComponent<Camera>().ScreenToWorldPoint(pos);
            float width = 0.2f * 3;
            float height = 0.5f * 2;
            Trapper[0] = new Vector3(pos.x - width, pos.y - height);
            Trapper[1] = new Vector3(pos.x - width, pos.y + height);
            Trapper[2] = new Vector3(pos.x + width, pos.y + height);
            Trapper[3] = new Vector3(pos.x + width, pos.y - height);
        }
        //���������ʾ�����ڻ����еķ�Χ
        AshoreThirtyX = Vector2.Distance(YouthMyGeniusSee(canvas, Trapper[0]), YouthMyGeniusSee(canvas, Trapper[3])) / 2f;
        AshoreThirtyY = Vector2.Distance(YouthMyGeniusSee(canvas, Trapper[0]), YouthMyGeniusSee(canvas, Trapper[1])) / 2f;
        //���������ʾ���������
        float x= Trapper[0].x + ((Trapper[3].x - Trapper[0].x) / 2);
        float y= Trapper[0].y + ((Trapper[1].y - Trapper[0].y) / 2);
        Vector3 centerWorld = new Vector3(x, y, 0);
        Vector2 Burial= YouthMyGeniusSee(canvas, centerWorld);
        //�������ֲ����е����ı���
        Vector4 centerMat = new Vector4(Burial.x, Burial.y, 0, 0);
        Eminence = GetComponent<Image>().material;
        Eminence.SetVector("_Center", centerMat);
        //���㵱ǰ������ʾ����İ뾶
        RectTransform canRectTransform = canvas.transform as RectTransform;
        if (canRectTransform != null)
        {
            //��ȡ����������ĸ�����
            canRectTransform.GetWorldCorners(Trapper);
            //����ƫ�Ƴ�ʼֵ
            for (int i = 0; i < Trapper.Length; i++)
            {
                if (i % 2 == 0)
                {
                    BluefinThirtyX = Mathf.Max(Vector3.Distance(YouthMyGeniusSee(canvas, Trapper[i]), Burial), BluefinThirtyX);
                }
                else
                {
                    BluefinThirtyY = Mathf.Max(Vector3.Distance(YouthMyGeniusSee(canvas, Trapper[i]), Burial), BluefinThirtyY);
                }
            }
        }
        //�������ֲ����е�ǰƫ�Ƶı���
        Eminence.SetFloat("_SliderX", BluefinThirtyX);
        Eminence.SetFloat("_SliderY", BluefinThirtyY);
        Lung.transform.localScale = new Vector3(1, 1, 1);
        StartCoroutine(FairLung(Burial));
    }

    private IEnumerator FairLung(Vector2 center)
    {
        Lung.SetActive(false);
        yield return new WaitForSeconds(SmoothThey);

        Lung.transform.localPosition = new Vector2(center.x, center.y -50);
        GiftLungEpidermis();
        //Hand.SetActive(true);
    }
    /// <summary>
    /// �����ٶ�
    /// </summary>
    private float SmoothInventorX= 0f;
    private float SmoothInventorY= 0f;
    private void Update()
    {
        if (Eminence == null || Ashore == null) return;

        BluefinThirtyX = AshoreThirtyX;
        Eminence.SetFloat("_SliderX", BluefinThirtyX);
        BluefinThirtyY = AshoreThirtyY;
        Eminence.SetFloat("_SliderY", BluefinThirtyY);


        /* //�ӵ�ǰƫ������Ŀ��ƫ������ֵ��ʾ��������
         float valueX = Mathf.SmoothDamp(currentOffsetX, targetOffsetX, ref shrinkVelocityX, shrinkTime);
         float valueY = Mathf.SmoothDamp(currentOffsetY, targetOffsetY, ref shrinkVelocityY, shrinkTime);
         if (!Mathf.Approximately(valueX, currentOffsetX))
         {
             currentOffsetX = valueX;
             material.SetFloat("_SliderX", currentOffsetX);
         }
         if (!Mathf.Approximately(valueY, currentOffsetY))
         {
             currentOffsetY = valueY;
             material.SetFloat("_SliderY", currentOffsetY);
         }*/


    }

    /// <summary>
    /// ��������ת��Ϊ��������
    /// </summary>
    /// <param name="canvas">����</param>
    /// <param name="world">��������</param>
    /// <returns></returns>
    private Vector2 YouthMyGeniusSee(Canvas canvas, Vector3 world)
    {
        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform, world, canvas.GetComponent<Camera>(), out position);
        return position;
    }

    public void GiftLungEpidermis()
    {

        var s = DOTween.Sequence();
        s.Append(Lung.transform.DOLocalMoveY(Lung.transform.localPosition.y + 10f, 0.5f));
        s.Append(Lung.transform.DOLocalMoveY(Lung.transform.localPosition.y, 0.5f));
        //s.Join(Hand.transform.DOScaleY(1.1f, 0.02f));
        //s.Join(Hand.transform.DOScaleX(0.9f, 0.02f).OnComplete(() =>
        //{
        //    Hand.transform.DOScaleY(0.9f, 0.02f);
        //    Hand.transform.DOScaleX(1.1f, 0.02f).OnComplete(() =>
        //    {
        //        Hand.transform.DOScale(1f, 0.02f);
        //    });
        //}));
        s.SetLoops(-1);
        s.SetId("NewUserHandAnimation");
    }

    public void OnDisable()
    {
        DOTween.Kill("NewUserHandAnimation");
    }
}
