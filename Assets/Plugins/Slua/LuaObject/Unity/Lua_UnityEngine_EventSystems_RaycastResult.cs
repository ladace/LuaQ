using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_RaycastResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult o;
		o=new UnityEngine.EventSystems.RaycastResult();
		pushValue(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Clear(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult self;
		checkValueType(l,1,out self);
		self.Clear();
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_module(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult self;
		checkValueType(l,1,out self);
		pushValue(l,self.module);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_module(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult self;
		checkValueType(l,1,out self);
		UnityEngine.EventSystems.BaseRaycaster v;
		checkType(l,2,out v);
		self.module=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_distance(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult self;
		checkValueType(l,1,out self);
		pushValue(l,self.distance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_distance(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult self;
		checkValueType(l,1,out self);
		System.Single v;
		checkType(l,2,out v);
		self.distance=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_index(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult self;
		checkValueType(l,1,out self);
		pushValue(l,self.index);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_index(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult self;
		checkValueType(l,1,out self);
		System.Single v;
		checkType(l,2,out v);
		self.index=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_depth(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult self;
		checkValueType(l,1,out self);
		pushValue(l,self.depth);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_depth(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult self;
		checkValueType(l,1,out self);
		System.Int32 v;
		checkType(l,2,out v);
		self.depth=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sortingLayer(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult self;
		checkValueType(l,1,out self);
		pushValue(l,self.sortingLayer);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sortingLayer(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult self;
		checkValueType(l,1,out self);
		System.Int32 v;
		checkType(l,2,out v);
		self.sortingLayer=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sortingOrder(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult self;
		checkValueType(l,1,out self);
		pushValue(l,self.sortingOrder);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sortingOrder(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult self;
		checkValueType(l,1,out self);
		System.Int32 v;
		checkType(l,2,out v);
		self.sortingOrder=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldPosition(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult self;
		checkValueType(l,1,out self);
		pushValue(l,self.worldPosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_worldPosition(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult self;
		checkValueType(l,1,out self);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		self.worldPosition=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldNormal(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult self;
		checkValueType(l,1,out self);
		pushValue(l,self.worldNormal);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_worldNormal(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult self;
		checkValueType(l,1,out self);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		self.worldNormal=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gameObject(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult self;
		checkValueType(l,1,out self);
		pushValue(l,self.gameObject);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_gameObject(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult self;
		checkValueType(l,1,out self);
		UnityEngine.GameObject v;
		checkType(l,2,out v);
		self.gameObject=v;
		setBack(l,self);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isValid(IntPtr l) {
		UnityEngine.EventSystems.RaycastResult self;
		checkValueType(l,1,out self);
		pushValue(l,self.isValid);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.RaycastResult");
		addMember(l,Clear);
		addMember(l,"module",get_module,set_module,true);
		addMember(l,"distance",get_distance,set_distance,true);
		addMember(l,"index",get_index,set_index,true);
		addMember(l,"depth",get_depth,set_depth,true);
		addMember(l,"sortingLayer",get_sortingLayer,set_sortingLayer,true);
		addMember(l,"sortingOrder",get_sortingOrder,set_sortingOrder,true);
		addMember(l,"worldPosition",get_worldPosition,set_worldPosition,true);
		addMember(l,"worldNormal",get_worldNormal,set_worldNormal,true);
		addMember(l,"gameObject",get_gameObject,set_gameObject,true);
		addMember(l,"isValid",get_isValid,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.EventSystems.RaycastResult),typeof(System.ValueType));
	}
}
