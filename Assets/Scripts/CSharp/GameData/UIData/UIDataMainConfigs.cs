﻿#region --------------------------文件信息--------------------------------------
/******************************************************************
** 文件名:	UIDataMain
** 版  权:	(C)  
** 创建人:  Unity喵
** 日  期:	
** 描  述: 	
*******************************************************************/
#endregion
using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LoveYouForever
{
    [CreateAssetMenu(fileName = "UIDataMain",menuName = "GameData/UIData/Main")]
	public class UIDataMainConfigs : ConfigsBase
    {
        [ShowInInspector]
        public int Test;
	}
}