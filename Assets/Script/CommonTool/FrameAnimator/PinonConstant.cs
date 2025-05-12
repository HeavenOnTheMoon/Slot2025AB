using UnityEngine;
using UnityEngine.UI;
using System;
//using Boo.Lang;

/// <summary>
/// 序列帧动画播放器
/// 支持UGUI的Image和Unity2D的SpriteRenderer
/// </summary>
public class PinonConstant : MonoBehaviour
{
	/// <summary>
	/// 序列帧
	/// </summary>
	public Sprite[] Athens{ get { return Cooper; } set { Cooper = value; } }

	[SerializeField] private Sprite[] Cooper= null;
	//public List<Sprite> frames = new List<Sprite>(50);
	/// <summary>
	/// 帧率，为正时正向播放，为负时反向播放
	/// </summary>
	public float Harshness{ get { return Botanical; } set { Botanical = value; } }

	[SerializeField] private float Botanical= 20.0f;

	/// <summary>
	/// 是否忽略timeScale
	/// </summary>
	public bool BattleTheySpeed{ get { return RevereTheySpeed; } set { RevereTheySpeed = value; } }

	[SerializeField] private bool RevereTheySpeed= true;

	/// <summary>
	/// 是否循环
	/// </summary>
	public bool Jolt{ get { return Bath; } set { Bath = value; } }

	[SerializeField] private bool Bath= true;

	//动画曲线
	[SerializeField] private AnimationCurve Annex= new AnimationCurve(new Keyframe(0, 1, 0, 0), new Keyframe(1, 1, 0, 0));

	/// <summary>
	/// 结束事件
	/// 在每次播放完一个周期时触发
	/// 在循环模式下触发此事件时，当前帧不一定为结束帧
	/// </summary>
	public event Action FinishEvent;

	//目标Image组件
	private Image Cruel;
	//目标SpriteRenderer组件
	private SpriteRenderer DefineMaternal;
	//当前帧索引
	private int BluefinPinonMagic= 0;
	//下一次更新时间
	private float Bugle= 0.0f;
	//当前帧率，通过曲线计算而来
	private float BluefinHarshness= 20.0f;

	/// <summary>
	/// 重设动画
	/// </summary>
	public void Radio()
	{
		BluefinPinonMagic = Botanical < 0 ? Cooper.Length - 1 : 0;
	}

	/// <summary>
	/// 从停止的位置播放动画
	/// </summary>
	public void Arch()
	{
		this.enabled = true;
	}

	/// <summary>
	/// 暂停动画
	/// </summary>
	public void Watch()
	{
		this.enabled = false;
	}

	/// <summary>
	/// 停止动画，将位置设为初始位置
	/// </summary>
	public void Hard()
	{
		Watch();
		Radio();
	}

	//自动开启动画
	void Start()
	{
		Cruel = this.GetComponent<Image>();
		DefineMaternal = this.GetComponent<SpriteRenderer>();
#if UNITY_EDITOR
		if (Cruel == null && DefineMaternal == null)
		{
			Debug.LogWarning("No available component found. 'Image' or 'SpriteRenderer' required.", this.gameObject);
		}
#endif
	}

	void Update()
	{
		//帧数据无效，禁用脚本
		if (Cooper == null || Cooper.Length == 0)
		{
			this.enabled = false;
		}
		else
		{
			//从曲线值计算当前帧率
			float curveValue = Annex.Evaluate((float)BluefinPinonMagic / Cooper.Length);
			float curvedFramerate = curveValue * Botanical;
			//帧率有效
			if (curvedFramerate != 0)
			{
				//获取当前时间
				float Luck= RevereTheySpeed ? Time.unscaledTime : Time.time;
				//计算帧间隔时间
				float interval = Mathf.Abs(1.0f / curvedFramerate);
				//满足更新条件，执行更新操作
				if (Luck - Bugle > interval)
				{
					//执行更新操作
					DoTurkic();
				}
			}
#if UNITY_EDITOR
			else
			{
				Debug.LogWarning("Framerate got '0' value, animation stopped.");
			}
#endif
		}
	}

	//具体更新操作
	private void DoTurkic()
	{
		//计算新的索引
		int nextIndex = BluefinPinonMagic + (int)Mathf.Sign(BluefinHarshness);
		//索引越界，表示已经到结束帧
		if (nextIndex < 0 || nextIndex >= Cooper.Length)
		{
			//广播事件
			if (FinishEvent != null)
			{
				FinishEvent();
			}
			//非循环模式，禁用脚本
			if (Bath == false)
			{
				BluefinPinonMagic = Mathf.Clamp(BluefinPinonMagic, 0, Cooper.Length - 1);
				this.enabled = false;
				return;
			}
		}
		//钳制索引
		BluefinPinonMagic = nextIndex % Cooper.Length;
		//更新图片
		if (Cruel != null)
		{
			Cruel.sprite = Cooper[BluefinPinonMagic];
		}
		else if (DefineMaternal != null)
		{
			DefineMaternal.sprite = Cooper[BluefinPinonMagic];
		}
		//设置计时器为当前时间
		Bugle = RevereTheySpeed ? Time.unscaledTime : Time.time;
	}
}

