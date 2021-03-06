using UnityEngine;
using System.Collections;

/// <summary> 协议-用户信息 </summary>
public class UserDataMessage
{
    /// <summary> 等级 </summary>
    public int Level { get; set; }

    /// <summary> 经验 </summary>
    public int Exp { get; set; }

    /// <summary> 活力值 </summary>
    public int Ap { get; set; }

    /// <summary> 金钱 </summary>
    public int Money { get; set; }

    /// <summary> 金币 </summary>
    public int Gold { get; set; }

    /// <summary> 荣誉 </summary>
    public int Honor { get; set; }
}
