using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;
public class PageBisonEmbryo : EarnCommunity<PageBisonEmbryo>
{
    public string Swiftly= "1.2";
    public string FistFend= SpyLimeYet.instance.FistFend;
    //channel
#if UNITY_IOS
    private string Fitting= "AppStore";
#elif UNITY_ANDROID
    private string Channel = "GooglePlay";
#else
    private string Channel = "GooglePlay";
#endif


    private void OnApplicationPause(bool pause)
    {
        PageBisonEmbryo.LawFigurine().BuzzFistSecretin();
    }

    public Text Sail;

    protected override void Awake()
    {
        base.Awake();

        Swiftly = Application.version;
        StartCoroutine(nameof(CostRewrite));
    }
    IEnumerator CostRewrite()
    {
        while (true)
        {
            yield return new WaitForSeconds(120f);
            PageBisonEmbryo.LawFigurine().BuzzFistSecretin();
        }
    }
    private void Start()
    {
        if (GripCopyVaguely.LawAid("event_day") != DateTime.Now.Day && GripCopyVaguely.LawExcess("user_servers_id").Length != 0)
        {
            GripCopyVaguely.MadAid("event_day", DateTime.Now.Day);
        }
    }
    public void SeatWeParaBison(string event_id)
    {
        SeatBison(event_id);
    }
    public void BuzzFistSecretin(List<string> valueList = null)
    {
        if (GripCopyVaguely.LawSummer(CLazily.Dy_SerigraphyVineHave) == 0)
        {
            GripCopyVaguely.MadSummer(CLazily.Dy_SerigraphyVineHave, GripCopyVaguely.LawSummer(CLazily.Dy_VineHave));
        }
        if (GripCopyVaguely.LawSummer(CLazily.Dy_SerigraphyBloom) == 0)
        {
            GripCopyVaguely.MadSummer(CLazily.Dy_SerigraphyBloom, GripCopyVaguely.LawSummer(CLazily.Dy_Bloom));
        }
        if (valueList == null)
        {
            valueList = new List<string>() {
                GripCopyVaguely.LawAid(CLazily.Dy_Bloom).ToString(),
                GripCopyVaguely.LawAid(CLazily.Dy_SerigraphyBloom).ToString(),
                FortCopyVaguely.instance.HimHerdLittle.ToString()
            };
        }

        if (GripCopyVaguely.LawExcess(CLazily.Dy_BlameMassifHe) == null)
        {
            return;
        }
        WWWForm wwwForm = new WWWForm();
        wwwForm.AddField("gameCode", FistFend);
        wwwForm.AddField("userId", GripCopyVaguely.LawExcess(CLazily.Dy_BlameMassifHe));

        wwwForm.AddField("gameVersion", Swiftly);

        wwwForm.AddField("channel", Fitting);

        for (int i = 0; i < valueList.Count; i++)
        {
            wwwForm.AddField("resource" + (i + 1), valueList[i]);
        }



        StartCoroutine(SeatPage(SpyLimeYet.instance.BaseHow + "/api/client/game_progress", wwwForm,
        (error) =>
        {
            Debug.Log(error);
        },
        (message) =>
        {
            Debug.Log(message);
        }));
    }
    public void SeatBison(string event_id, string p1 = null, string p2 = null, string p3 = null)
    {
        if (Sail != null)
        {
            if (int.Parse(event_id) < 9100 && int.Parse(event_id) >= 9000)
            {
                if (p1 == null)
                {
                    p1 = "";
                }
                Sail.text += "\n" + DateTime.Now.ToString() + "id:" + event_id + "  p1:" + p1;
            }
        }
        if (GripCopyVaguely.LawExcess(CLazily.Dy_BlameMassifHe) == null)
        {
            SpyLimeYet.instance.Along();
            return;
        }
        WWWForm wwwForm = new WWWForm();
        wwwForm.AddField("gameCode", FistFend);
        wwwForm.AddField("userId", GripCopyVaguely.LawExcess(CLazily.Dy_BlameMassifHe));
        //Debug.Log("userId:" + GripCopyVaguely.GetString(CLazily.sv_LocalServerId));
        wwwForm.AddField("version", Swiftly);
        //Debug.Log("version:" + version);
        wwwForm.AddField("channel", Fitting);
        //Debug.Log("channel:" + channal);
        wwwForm.AddField("operateId", event_id);
        Debug.Log("operateId:" + event_id);


        if (p1 != null)
        {
            wwwForm.AddField("params1", p1);
        }
        if (p2 != null)
        {
            wwwForm.AddField("params2", p2);
        }
        if (p3 != null)
        {
            wwwForm.AddField("params3", p3);
        }
        StartCoroutine(SeatPage(SpyLimeYet.instance.BaseHow + "/api/client/log", wwwForm,
        (error) =>
        {
            Debug.Log(error);
        },
        (message) =>
        {
            Debug.Log(message);
        }));
    }
    IEnumerator SeatPage(string _url, WWWForm wwwForm, Action<string> fail, Action<string> success)
    {
        //Debug.Log(SerializeDictionaryToJsonString(dic));
        UnityWebRequest request = UnityWebRequest.Post(_url, wwwForm);
        yield return request.SendWebRequest();
        if (request.isNetworkError || request.isNetworkError)
        {
            fail(request.error);
            endDaytime();
            request.Dispose();
        }
        else
        {
            success(request.downloadHandler.text);
            endDaytime();
            request.Dispose();
        }

    }
    private void endDaytime()
    {
        StopCoroutine(nameof(SeatPage));
    }


}