﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Assertions_Assert : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsTrue_s(IntPtr l) {
		int argc = LuaDLL.lua_gettop(l);
		if(argc==1){
			System.Boolean a1;
			checkType(l,1,out a1);
			UnityEngine.Assertions.Assert.IsTrue(a1);
			return 0;
		}
		else if(argc==2){
			System.Boolean a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			UnityEngine.Assertions.Assert.IsTrue(a1,a2);
			return 0;
		}
		LuaDLL.luaL_error(l,"No matched override function to call");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsFalse_s(IntPtr l) {
		int argc = LuaDLL.lua_gettop(l);
		if(argc==1){
			System.Boolean a1;
			checkType(l,1,out a1);
			UnityEngine.Assertions.Assert.IsFalse(a1);
			return 0;
		}
		else if(argc==2){
			System.Boolean a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			UnityEngine.Assertions.Assert.IsFalse(a1,a2);
			return 0;
		}
		LuaDLL.luaL_error(l,"No matched override function to call");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AreApproximatelyEqual_s(IntPtr l) {
		int argc = LuaDLL.lua_gettop(l);
		if(argc==2){
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.Assertions.Assert.AreApproximatelyEqual(a1,a2);
			return 0;
		}
		else if(matchType(l,argc,1,typeof(float),typeof(float),typeof(float))){
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.Assertions.Assert.AreApproximatelyEqual(a1,a2,a3);
			return 0;
		}
		else if(matchType(l,argc,1,typeof(float),typeof(float),typeof(string))){
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			UnityEngine.Assertions.Assert.AreApproximatelyEqual(a1,a2,a3);
			return 0;
		}
		else if(argc==4){
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.String a4;
			checkType(l,4,out a4);
			UnityEngine.Assertions.Assert.AreApproximatelyEqual(a1,a2,a3,a4);
			return 0;
		}
		LuaDLL.luaL_error(l,"No matched override function to call");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AreNotApproximatelyEqual_s(IntPtr l) {
		int argc = LuaDLL.lua_gettop(l);
		if(argc==2){
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.Assertions.Assert.AreNotApproximatelyEqual(a1,a2);
			return 0;
		}
		else if(matchType(l,argc,1,typeof(float),typeof(float),typeof(float))){
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.Assertions.Assert.AreNotApproximatelyEqual(a1,a2,a3);
			return 0;
		}
		else if(matchType(l,argc,1,typeof(float),typeof(float),typeof(string))){
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			UnityEngine.Assertions.Assert.AreNotApproximatelyEqual(a1,a2,a3);
			return 0;
		}
		else if(argc==4){
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.String a4;
			checkType(l,4,out a4);
			UnityEngine.Assertions.Assert.AreNotApproximatelyEqual(a1,a2,a3,a4);
			return 0;
		}
		LuaDLL.luaL_error(l,"No matched override function to call");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_raiseExceptions(IntPtr l) {
		pushValue(l,UnityEngine.Assertions.Assert.raiseExceptions);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_raiseExceptions(IntPtr l) {
		System.Boolean v;
		checkType(l,2,out v);
		UnityEngine.Assertions.Assert.raiseExceptions=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Assertions.Assert");
		addMember(l,IsTrue_s);
		addMember(l,IsFalse_s);
		addMember(l,AreApproximatelyEqual_s);
		addMember(l,AreNotApproximatelyEqual_s);
		addMember(l,"raiseExceptions",get_raiseExceptions,set_raiseExceptions,false);
		createTypeMetatable(l,null, typeof(UnityEngine.Assertions.Assert));
	}
}
