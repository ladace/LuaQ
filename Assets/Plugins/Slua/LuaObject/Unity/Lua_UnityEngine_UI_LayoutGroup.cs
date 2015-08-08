using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_LayoutGroup : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculateLayoutInputHorizontal(IntPtr l) {
		UnityEngine.UI.LayoutGroup self=(UnityEngine.UI.LayoutGroup)checkSelf(l);
		self.CalculateLayoutInputHorizontal();
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculateLayoutInputVertical(IntPtr l) {
		UnityEngine.UI.LayoutGroup self=(UnityEngine.UI.LayoutGroup)checkSelf(l);
		self.CalculateLayoutInputVertical();
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetLayoutHorizontal(IntPtr l) {
		UnityEngine.UI.LayoutGroup self=(UnityEngine.UI.LayoutGroup)checkSelf(l);
		self.SetLayoutHorizontal();
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetLayoutVertical(IntPtr l) {
		UnityEngine.UI.LayoutGroup self=(UnityEngine.UI.LayoutGroup)checkSelf(l);
		self.SetLayoutVertical();
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_padding(IntPtr l) {
		UnityEngine.UI.LayoutGroup self=(UnityEngine.UI.LayoutGroup)checkSelf(l);
		pushValue(l,self.padding);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_padding(IntPtr l) {
		UnityEngine.UI.LayoutGroup self=(UnityEngine.UI.LayoutGroup)checkSelf(l);
		UnityEngine.RectOffset v;
		checkType(l,2,out v);
		self.padding=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_childAlignment(IntPtr l) {
		UnityEngine.UI.LayoutGroup self=(UnityEngine.UI.LayoutGroup)checkSelf(l);
		pushEnum(l,(int)self.childAlignment);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_childAlignment(IntPtr l) {
		UnityEngine.UI.LayoutGroup self=(UnityEngine.UI.LayoutGroup)checkSelf(l);
		UnityEngine.TextAnchor v;
		checkEnum(l,2,out v);
		self.childAlignment=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minWidth(IntPtr l) {
		UnityEngine.UI.LayoutGroup self=(UnityEngine.UI.LayoutGroup)checkSelf(l);
		pushValue(l,self.minWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_preferredWidth(IntPtr l) {
		UnityEngine.UI.LayoutGroup self=(UnityEngine.UI.LayoutGroup)checkSelf(l);
		pushValue(l,self.preferredWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_flexibleWidth(IntPtr l) {
		UnityEngine.UI.LayoutGroup self=(UnityEngine.UI.LayoutGroup)checkSelf(l);
		pushValue(l,self.flexibleWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minHeight(IntPtr l) {
		UnityEngine.UI.LayoutGroup self=(UnityEngine.UI.LayoutGroup)checkSelf(l);
		pushValue(l,self.minHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_preferredHeight(IntPtr l) {
		UnityEngine.UI.LayoutGroup self=(UnityEngine.UI.LayoutGroup)checkSelf(l);
		pushValue(l,self.preferredHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_flexibleHeight(IntPtr l) {
		UnityEngine.UI.LayoutGroup self=(UnityEngine.UI.LayoutGroup)checkSelf(l);
		pushValue(l,self.flexibleHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_layoutPriority(IntPtr l) {
		UnityEngine.UI.LayoutGroup self=(UnityEngine.UI.LayoutGroup)checkSelf(l);
		pushValue(l,self.layoutPriority);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.LayoutGroup");
		addMember(l,CalculateLayoutInputHorizontal);
		addMember(l,CalculateLayoutInputVertical);
		addMember(l,SetLayoutHorizontal);
		addMember(l,SetLayoutVertical);
		addMember(l,"padding",get_padding,set_padding,true);
		addMember(l,"childAlignment",get_childAlignment,set_childAlignment,true);
		addMember(l,"minWidth",get_minWidth,null,true);
		addMember(l,"preferredWidth",get_preferredWidth,null,true);
		addMember(l,"flexibleWidth",get_flexibleWidth,null,true);
		addMember(l,"minHeight",get_minHeight,null,true);
		addMember(l,"preferredHeight",get_preferredHeight,null,true);
		addMember(l,"flexibleHeight",get_flexibleHeight,null,true);
		addMember(l,"layoutPriority",get_layoutPriority,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.UI.LayoutGroup),typeof(UnityEngine.EventSystems.UIBehaviour));
	}
}
