using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AssetBundle : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UnityEngine.AssetBundle o;
		o=new UnityEngine.AssetBundle();
		pushValue(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Contains(IntPtr l) {
		UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
		System.String a1;
		checkType(l,2,out a1);
		var ret=self.Contains(a1);
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LoadAsset(IntPtr l) {
		int argc = LuaDLL.lua_gettop(l);
		if(argc==2){
			UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.LoadAsset(a1);
			pushValue(l,ret);
			return 1;
		}
		else if(argc==3){
			UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Type a2;
			checkType(l,3,out a2);
			var ret=self.LoadAsset(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		LuaDLL.luaL_error(l,"No matched override function to call");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LoadAssetAsync(IntPtr l) {
		int argc = LuaDLL.lua_gettop(l);
		if(argc==2){
			UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.LoadAssetAsync(a1);
			pushValue(l,ret);
			return 1;
		}
		else if(argc==3){
			UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Type a2;
			checkType(l,3,out a2);
			var ret=self.LoadAssetAsync(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		LuaDLL.luaL_error(l,"No matched override function to call");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LoadAssetWithSubAssets(IntPtr l) {
		int argc = LuaDLL.lua_gettop(l);
		if(argc==2){
			UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.LoadAssetWithSubAssets(a1);
			pushValue(l,ret);
			return 1;
		}
		else if(argc==3){
			UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Type a2;
			checkType(l,3,out a2);
			var ret=self.LoadAssetWithSubAssets(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		LuaDLL.luaL_error(l,"No matched override function to call");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LoadAssetWithSubAssetsAsync(IntPtr l) {
		int argc = LuaDLL.lua_gettop(l);
		if(argc==2){
			UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.LoadAssetWithSubAssetsAsync(a1);
			pushValue(l,ret);
			return 1;
		}
		else if(argc==3){
			UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Type a2;
			checkType(l,3,out a2);
			var ret=self.LoadAssetWithSubAssetsAsync(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		LuaDLL.luaL_error(l,"No matched override function to call");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LoadAllAssets(IntPtr l) {
		int argc = LuaDLL.lua_gettop(l);
		if(argc==1){
			UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
			var ret=self.LoadAllAssets();
			pushValue(l,ret);
			return 1;
		}
		else if(argc==2){
			UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
			System.Type a1;
			checkType(l,2,out a1);
			var ret=self.LoadAllAssets(a1);
			pushValue(l,ret);
			return 1;
		}
		LuaDLL.luaL_error(l,"No matched override function to call");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LoadAllAssetsAsync(IntPtr l) {
		int argc = LuaDLL.lua_gettop(l);
		if(argc==1){
			UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
			var ret=self.LoadAllAssetsAsync();
			pushValue(l,ret);
			return 1;
		}
		else if(argc==2){
			UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
			System.Type a1;
			checkType(l,2,out a1);
			var ret=self.LoadAllAssetsAsync(a1);
			pushValue(l,ret);
			return 1;
		}
		LuaDLL.luaL_error(l,"No matched override function to call");
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Unload(IntPtr l) {
		UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
		System.Boolean a1;
		checkType(l,2,out a1);
		self.Unload(a1);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetAllAssetNames(IntPtr l) {
		UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
		var ret=self.GetAllAssetNames();
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetAllScenePaths(IntPtr l) {
		UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
		var ret=self.GetAllScenePaths();
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CreateFromMemory_s(IntPtr l) {
		System.Byte[] a1;
		checkType(l,1,out a1);
		var ret=UnityEngine.AssetBundle.CreateFromMemory(a1);
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CreateFromMemoryImmediate_s(IntPtr l) {
		System.Byte[] a1;
		checkType(l,1,out a1);
		var ret=UnityEngine.AssetBundle.CreateFromMemoryImmediate(a1);
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CreateFromFile_s(IntPtr l) {
		System.String a1;
		checkType(l,1,out a1);
		var ret=UnityEngine.AssetBundle.CreateFromFile(a1);
		pushValue(l,ret);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mainAsset(IntPtr l) {
		UnityEngine.AssetBundle self=(UnityEngine.AssetBundle)checkSelf(l);
		pushValue(l,self.mainAsset);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AssetBundle");
		addMember(l,Contains);
		addMember(l,LoadAsset);
		addMember(l,LoadAssetAsync);
		addMember(l,LoadAssetWithSubAssets);
		addMember(l,LoadAssetWithSubAssetsAsync);
		addMember(l,LoadAllAssets);
		addMember(l,LoadAllAssetsAsync);
		addMember(l,Unload);
		addMember(l,GetAllAssetNames);
		addMember(l,GetAllScenePaths);
		addMember(l,CreateFromMemory_s);
		addMember(l,CreateFromMemoryImmediate_s);
		addMember(l,CreateFromFile_s);
		addMember(l,"mainAsset",get_mainAsset,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AssetBundle),typeof(UnityEngine.Object));
	}
}
