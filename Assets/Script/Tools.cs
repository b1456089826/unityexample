using UnityEngine;
using System.Collections;

public class Tools : MonoBehaviour {

   /**
	* int x 绘制数字X轴坐标
	* int y 绘制数字Y轴坐标
	* Object[] texmube 绘制的图片数组资源
	*/
	public static void DrawImageNumber(int x,int y,int mumber,Object[] texmube)
	{
		//将整形转成字符数组
		char[] chars = mumber.ToString().ToCharArray();
		//计算图片的宽度与高度
		Texture2D tex = (Texture2D)texmube[0];
		int width = tex.width;
		int height = tex.height;
		//遍历字符数组
		foreach (char s in chars)
		{
			//得到每一位整形数据
			int i = int.Parse(s.ToString()) ;
			//绘制图片数字
			GUI.DrawTexture(new Rect(x,y,width,height),(Texture2D)texmube[i]);
			x += width;
		}
	}
}
