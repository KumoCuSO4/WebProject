﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class ToLuaTestWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(ToLuaTest), typeof(System.Object));
		L.RegFunction("GetResult", GetResult);
		L.RegFunction("New", _CreateToLuaTest);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateToLuaTest(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				ToLuaTest obj = new ToLuaTest();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: ToLuaTest.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetResult(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ToLuaTest obj = (ToLuaTest)ToLua.CheckObject<ToLuaTest>(L, 1);
			int[,] arg0 = (int[,])ToLua.CheckObject(L, 2, typeof(int[,]));
			int o = obj.GetResult(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

