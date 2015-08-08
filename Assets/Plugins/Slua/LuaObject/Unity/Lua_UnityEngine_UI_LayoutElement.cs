using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_LayoutElement : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculateLayoutInputHorizontal(IntPtr l) {
		UnityEngine.UI.LayoutElement self=(UnityEngine.UI.LayoutElement)checkSelf(l);
		self.CalculateLayoutInputHorizontal();
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculateLayoutInputVertical(IntPtr l) {
		UnityEngine.UI.LayoutElement self=(UnityEngine.UI.LayoutElement)checkSelf(l);
		self.CalculateLayoutInputVertical();
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ignoreLayout(IntPtr l) {
		UnityEngine.UI.LayoutElement self=(UnityEngine.UI.LayoutElement)checkSelf(l);
		pushValue(l,self.ignoreLayout);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_ignoreLayout(IntPtr l) {
		UnityEngine.UI.LayoutElement self=(UnityEngine.UI.LayoutElement)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		self.ignoreLayout=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minWidth(IntPtr l) {
		UnityEngine.UI.LayoutElement self=(UnityEngine.UI.LayoutElement)checkSelf(l);
		pushValue(l,self.minWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minWidth(IntPtr l) {
		UnityEngine.UI.LayoutElement self=(UnityEngine.UI.LayoutElement)checkSelf(l);
		float v;
		checkType(l,2,out v);
		self.minWidth=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minHeight(IntPtr l) {
		UnityEngine.UI.LayoutElement self=(UnityEngine.UI.LayoutElement)checkSelf(l);
		pushValue(l,self.minHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minHeight(IntPtr l) {
		UnityEngine.UI.LayoutElement self=(UnityEngine.UI.LayoutElement)checkSelf(l);
		float v;
		checkType(l,2,out v);
		self.minHeight=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_preferredWidth(IntPtr l) {
		UnityEngine.UI.LayoutElement self=(UnityEngine.UI.LayoutElement)checkSelf(l);
		pushValue(l,self.preferredWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_preferredWidth(IntPtr l) {
		UnityEngine.UI.LayoutElement self=(UnityEngine.UI.LayoutElement)checkSelf(l);
		float v;
		checkType(l,2,out v);
		self.preferredWidth=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_preferredHeight(IntPtr l) {
		UnityEngine.UI.LayoutElement self=(UnityEngine.UI.LayoutElement)checkSelf(l);
		pushValue(l,self.preferredHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_preferredHeight(IntPtr l) {
		UnityEngine.UI.LayoutElement self=(UnityEngine.UI.LayoutElement)checkSelf(l);
		float v;
		checkType(l,2,out v);
		self.preferredHeight=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_flexibleWidth(IntPtr l) {
		UnityEngine.UI.LayoutElement self=(UnityEngine.UI.LayoutElement)checkSelf(l);
		pushValue(l,self.flexibleWidth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_flexibleWidth(IntPtr l) {
		UnityEngine.UI.LayoutElement self=(UnityEngine.UI.LayoutElement)checkSelf(l);
		float v;
		checkType(l,2,out v);
		self.flexibleWidth=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_flexibleHeight(IntPtr l) {
		UnityEngine.UI.LayoutElement self=(UnityEngine.UI.LayoutElement)checkSelf(l);
		pushValue(l,self.flexibleHeight);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_flexibleHeight(IntPtr l) {
		UnityEngine.UI.LayoutElement self=(UnityEngine.UI.LayoutElement)checkSelf(l);
		float v;
		checkType(l,2,out v);
		self.flexibleHeight=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_layoutPriority(IntPtr l) {
		UnityEngine.UI.LayoutElement self=(UnityEngine.UI.LayoutElement)checkSelf(l);
		pushValue(l,self.layoutPriority);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.LayoutElement");
		addMember(l,CalculateLayoutInputHorizontal);
		addMember(l,CalculateLayoutInputVertical);
		addMember(l,"ignoreLayout",get_ignoreLayout,set_ignoreLayout,true);
		addMember(l,"minWidth",get_minWidth,set_minWidth,true);
		addMember(l,"minHeight",get_minHeight,set_minHeight,true);
		addMember(l,"preferredWidth",get_preferredWidth,set_preferredWidth,true);
		addMember(l,"preferredHeight",get_preferredHeight,set_preferredHeight,true);
		addMember(l,"flexibleWidth",get_flexibleWidth,set_flexibleWidth,true);
		addMember(l,"flexibleHeight",get_flexibleHeight,set_flexibleHeight,true);
		addMember(l,"layoutPriority",get_layoutPriority,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.UI.LayoutElement),typeof(UnityEngine.EventSystems.UIBehaviour));
	}
}
