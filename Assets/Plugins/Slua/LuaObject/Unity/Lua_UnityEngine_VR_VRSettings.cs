using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_VR_VRSettings : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.VR.VRSettings o;
		o=new UnityEngine.VR.VRSettings();
		pushValue(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enabled(IntPtr l) {
		pushValue(l,UnityEngine.VR.VRSettings.enabled);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enabled(IntPtr l) {
		bool v;
		checkType(l,2,out v);
		UnityEngine.VR.VRSettings.enabled=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_showDeviceView(IntPtr l) {
		pushValue(l,UnityEngine.VR.VRSettings.showDeviceView);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_showDeviceView(IntPtr l) {
		bool v;
		checkType(l,2,out v);
		UnityEngine.VR.VRSettings.showDeviceView=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_renderScale(IntPtr l) {
		pushValue(l,UnityEngine.VR.VRSettings.renderScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_renderScale(IntPtr l) {
		float v;
		checkType(l,2,out v);
		UnityEngine.VR.VRSettings.renderScale=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_loadedDevice(IntPtr l) {
		pushEnum(l,(int)UnityEngine.VR.VRSettings.loadedDevice);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_loadedDevice(IntPtr l) {
		UnityEngine.VR.VRDeviceType v;
		checkEnum(l,2,out v);
		UnityEngine.VR.VRSettings.loadedDevice=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.VR.VRSettings");
		addMember(l,"enabled",get_enabled,set_enabled,false);
		addMember(l,"showDeviceView",get_showDeviceView,set_showDeviceView,false);
		addMember(l,"renderScale",get_renderScale,set_renderScale,false);
		addMember(l,"loadedDevice",get_loadedDevice,set_loadedDevice,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.VR.VRSettings));
	}
}
