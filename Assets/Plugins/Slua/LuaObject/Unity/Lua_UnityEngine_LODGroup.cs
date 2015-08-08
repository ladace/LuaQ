﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_LODGroup : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.LODGroup o;
		o=new UnityEngine.LODGroup();
		pushValue(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RecalculateBounds(IntPtr l) {
		UnityEngine.LODGroup self=(UnityEngine.LODGroup)checkSelf(l);
		self.RecalculateBounds();
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetLODs(IntPtr l) {
		UnityEngine.LODGroup self=(UnityEngine.LODGroup)checkSelf(l);
		var ret=self.GetLODs();
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetLODs(IntPtr l) {
		UnityEngine.LODGroup self=(UnityEngine.LODGroup)checkSelf(l);
		UnityEngine.LOD[] a1;
		checkType(l,2,out a1);
		self.SetLODs(a1);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ForceLOD(IntPtr l) {
		UnityEngine.LODGroup self=(UnityEngine.LODGroup)checkSelf(l);
		System.Int32 a1;
		checkType(l,2,out a1);
		self.ForceLOD(a1);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_localReferencePoint(IntPtr l) {
		UnityEngine.LODGroup self=(UnityEngine.LODGroup)checkSelf(l);
		pushValue(l,self.localReferencePoint);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_localReferencePoint(IntPtr l) {
		UnityEngine.LODGroup self=(UnityEngine.LODGroup)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		self.localReferencePoint=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_size(IntPtr l) {
		UnityEngine.LODGroup self=(UnityEngine.LODGroup)checkSelf(l);
		pushValue(l,self.size);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_size(IntPtr l) {
		UnityEngine.LODGroup self=(UnityEngine.LODGroup)checkSelf(l);
		float v;
		checkType(l,2,out v);
		self.size=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lodCount(IntPtr l) {
		UnityEngine.LODGroup self=(UnityEngine.LODGroup)checkSelf(l);
		pushValue(l,self.lodCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fadeMode(IntPtr l) {
		UnityEngine.LODGroup self=(UnityEngine.LODGroup)checkSelf(l);
		pushEnum(l,(int)self.fadeMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fadeMode(IntPtr l) {
		UnityEngine.LODGroup self=(UnityEngine.LODGroup)checkSelf(l);
		UnityEngine.LODFadeMode v;
		checkEnum(l,2,out v);
		self.fadeMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_animateCrossFading(IntPtr l) {
		UnityEngine.LODGroup self=(UnityEngine.LODGroup)checkSelf(l);
		pushValue(l,self.animateCrossFading);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_animateCrossFading(IntPtr l) {
		UnityEngine.LODGroup self=(UnityEngine.LODGroup)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		self.animateCrossFading=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enabled(IntPtr l) {
		UnityEngine.LODGroup self=(UnityEngine.LODGroup)checkSelf(l);
		pushValue(l,self.enabled);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enabled(IntPtr l) {
		UnityEngine.LODGroup self=(UnityEngine.LODGroup)checkSelf(l);
		bool v;
		checkType(l,2,out v);
		self.enabled=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_crossFadeAnimationDuration(IntPtr l) {
		pushValue(l,UnityEngine.LODGroup.crossFadeAnimationDuration);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_crossFadeAnimationDuration(IntPtr l) {
		float v;
		checkType(l,2,out v);
		UnityEngine.LODGroup.crossFadeAnimationDuration=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.LODGroup");
		addMember(l,RecalculateBounds);
		addMember(l,GetLODs);
		addMember(l,SetLODs);
		addMember(l,ForceLOD);
		addMember(l,"localReferencePoint",get_localReferencePoint,set_localReferencePoint,true);
		addMember(l,"size",get_size,set_size,true);
		addMember(l,"lodCount",get_lodCount,null,true);
		addMember(l,"fadeMode",get_fadeMode,set_fadeMode,true);
		addMember(l,"animateCrossFading",get_animateCrossFading,set_animateCrossFading,true);
		addMember(l,"enabled",get_enabled,set_enabled,true);
		addMember(l,"crossFadeAnimationDuration",get_crossFadeAnimationDuration,set_crossFadeAnimationDuration,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.LODGroup),typeof(UnityEngine.Component));
	}
}
