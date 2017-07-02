package application;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;

@Entity
public class Vehicle {
public Vehicle() {
	// TODO Auto-generated constructor stub
}
@Id
@GeneratedValue(strategy=GenerationType.AUTO)
private int id;
private String vname;
private String vnumber;

@ManyToOne
@JoinColumn(name="USER_ID")
private User user;

public int getId() {
	return id;
}

public void setId(int id) {
	this.id = id;
}

public String getVname() {
	return vname;
}

public void setVname(String vname) {
	this.vname = vname;
}

public String getVnumber() {
	return vnumber;
}

public void setVnumber(String vnumber) {
	this.vnumber = vnumber;
}

public User getUser() {
	return user;
}

public void setUser(User user) {
	this.user = user;
}


}
