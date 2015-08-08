using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AnimatorStateInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.AnimatorStateInfo o;
		o=new UnityEngine.AnimatorStateInfo();
		pushValue(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsName(IntPtr l) {
		UnityEngine.AnimatorStateInfo self;
		checkValueType(l,1,out self);
		System.String a1;
		checkType(l,2,out a1);
		var ret=self.IsName(a1);
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsTag(IntPtr l) {
		UnityEngine.AnimatorStateInfo self;
		checkValueType(l,1,out self);
		System.String a1;
		checkType(l,2,out a1);
		var ret=self.IsTag(a1);
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fullPathHash(IntPtr l) {
		UnityEngine.AnimatorStateInfo self;
		checkValueType(l,1,out self);
		pushValue(l,self.fullPathHash);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shortNameHash(IntPtr l) {
		UnityEngine.AnimatorStateInfo self;
		checkValueType(l,1,out self);
		pushValue(l,self.shortNameHash);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normalizedTime(IntPtr l) {
		UnityEngine.AnimatorStateInfo self;
		checkValueType(l,1,out self);
		pushValue(l,self.normalizedTime);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_length(IntPtr l) {
		UnityEngine.AnimatorStateInfo self;
		checkValueType(l,1,out self);
		pushValue(l,self.length);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tagHash(IntPtr l) {
		UnityEngine.AnimatorStateInfo self;
		checkValueType(l,1,out self);
		pushValue(l,self.tagHash);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_loop(IntPtr l) {
		UnityEngine.AnimatorStateInfo self;
		checkValueType(l,1,out self);
		pushValue(l,self.loop);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AnimatorStateInfo");
		addMember(l,IsName);
		addMember(l,IsTag);
		addMember(l,"fullPathHash",get_fullPathHash,null,true);
		addMember(l,"shortNameHash",get_shortNameHash,null,true);
		addMember(l,"normalizedTime",get_normalizedTime,null,true);
		addMember(l,"length",get_length,null,true);
		addMember(l,"tagHash",get_tagHash,null,true);
		addMember(l,"loop",get_loop,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AnimatorStateInfo),typeof(System.ValueType));
	}
}
