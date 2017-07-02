package com.softpoint.app.model;

public class Contact {
	private int id;
	private String name;
	private String email;
	private String mobile;
	private String photo;
	
	public Contact() {
		// TODO Auto-generated constructor stub
	}

	
	
	public Contact(String name, String email, String mobile, String photo) {
		super();
		this.name = name;
		this.email = email;
		this.mobile = mobile;
		this.photo = photo;
	}



	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getEmail() {
		return email;
	}

	public void setEmail(String email) {
		this.email = email;
	}

	public String getMobile() {
		return mobile;
	}

	public void setMobile(String mobile) {
		this.mobile = mobile;
	}

	public String getPhoto() {
		return photo;
	}

	public void setPhoto(String photo) {
		this.photo = photo;
	}
	
	
}
