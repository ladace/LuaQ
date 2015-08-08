using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Projector : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.Projector o;
		o=new UnityEngine.Projector();
		pushValue(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_nearClipPlane(IntPtr l) {
		UnityEngine.Projector self=(UnityEngine.Projector)checkSelf(l);
		pushValue(l,self.nearClipPlane);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_nearClipPlane(IntPtr l) {
		UnityEngine.Projector self=(UnityEngine.Projector)checkSelf(l);
		float v;
		checkType(l,2,out v);
		self.nearClipPlane=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_farClipPlane(IntPtr l) {
		UnityEngine.Projector self=(UnityEngine.Projector)checkSelf(l);
		pushValue(l,self.farClipPlane);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_farClipPlane(IntPtr l) {
		UnityEngine.Projector self=(UnityEngine.Projector)checkSelf(l);
		float v;
		checkType(l,2,out v);
		self.farClipPlane=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fieldOfView(IntPtr l) {
		UnityEngine.Projector self=(UnityEngine.Projector)checkSelf(l);
		pushValue(l,self.fieldOfView);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fieldOfView(IntPtr l) {
		UnityEngine.Projector self=(UnityEngine.Projector)checkSelf(l);
		float v;
		checkType(l,2,out v);
		self.fieldOfView=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_aspectRatio(IntPtr l) {
		UnityEngine.Projector self=(UnityEngine.Projector)checkSelf(l);
		pushValue(l,self.aspectRatio);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_aspectRatio(IntPtr l) {
		UnityEngine.Projector self=(UnityEngine.Projector)checkSelf(l);
		float v;
		checkType(l,2,out v);
		self.aspectRatio=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_orthographic(IntPtr l) {
		UnityEngine.Projector self=(UnityEngine.Projector)checkSelf(l);
		pushValue(l,self.orthographic);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_orthographic(IntPtr l) {
		UnityEngine.Projector self=(UnityEngine.Projector)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		self.orthographic=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_orthographicSize(IntPtr l) {
		UnityEngine.Projector self=(UnityEngine.Projector)checkSelf(l);
		pushValue(l,self.orthographicSize);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_orthographicSize(IntPtr l) {
		UnityEngine.Projector self=(UnityEngine.Projector)checkSelf(l);
		float v;
		checkType(l,2,out v);
		self.orthographicSize=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ignoreLayers(IntPtr l) {
		UnityEngine.Projector self=(UnityEngine.Projector)checkSelf(l);
		pushValue(l,self.ignoreLayers);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_ignoreLayers(IntPtr l) {
		UnityEngine.Projector self=(UnityEngine.Projector)checkSelf(l);
		int v;
		checkType(l,2,out v);
		self.ignoreLayers=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_material(IntPtr l) {
		UnityEngine.Projector self=(UnityEngine.Projector)checkSelf(l);
		pushValue(l,self.material);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_material(IntPtr l) {
		UnityEngine.Projector self=(UnityEngine.Projector)checkSelf(l);
		UnityEngine.Material v;
		checkType(l,2,out v);
		self.material=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Projector");
		addMember(l,"nearClipPlane",get_nearClipPlane,set_nearClipPlane,true);
		addMember(l,"farClipPlane",get_farClipPlane,set_farClipPlane,true);
		addMember(l,"fieldOfView",get_fieldOfView,set_fieldOfView,true);
		addMember(l,"aspectRatio",get_aspectRatio,set_aspectRatio,true);
		addMember(l,"orthographic",get_orthographic,set_orthographic,true);
		addMember(l,"orthographicSize",get_orthographicSize,set_orthographicSize,true);
		addMember(l,"ignoreLayers",get_ignoreLayers,set_ignoreLayers,true);
		addMember(l,"material",get_material,set_material,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Projector),typeof(UnityEngine.Behaviour));
	}
}
