package com.service;

public class authentication {
	public boolean getAuth(String username2,String password2)
	{
		if(username2.equals("monish") && password2.equals("soni123"))
		{
			return true;
		}
		else
		{
		return false;
		}
	}
}
