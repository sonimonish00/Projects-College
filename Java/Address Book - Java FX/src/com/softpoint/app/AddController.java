package com.softpoint.app;

import java.net.URL;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ResourceBundle;

import com.softpoint.app.model.Contact;

import javafx.application.Platform;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Button;

import javafx.scene.control.TextField;
import javafx.stage.Stage;

public class AddController implements Initializable{
	@FXML
	private TextField txtName;
	@FXML
	private TextField txtEmail;
	@FXML
	private TextField txtMobile;
	@FXML
	private Button btnSave;
	@FXML
	private Button btnAddClose;

	private Main main;

	private Stage stage;

	public AddController() {
		// TODO Auto-generated constructor stub
	}
	@Override
	public void initialize(URL location, ResourceBundle resources) {
		btnSave.setOnAction(e -> {
			main.getContancts().add(new Contact(txtName.getText(), txtEmail.getText(), txtMobile.getText(), ""));

			try{
				Class.forName("com.mysql.jdbc.Driver");
				Connection  con=DriverManager.getConnection
	                    ("jdbc:mysql://localhost:3306/AddressBook?useSSL=false","root","");
	         String queryDB = "insert into contact (name,mobile,email) values ('"+txtName.getText()+"','"+txtMobile.getText()+"','"+txtEmail.getText()+"');";
	       Statement sd = con.createStatement();
	       sd.executeUpdate(queryDB);


			}
			catch(Exception ex)
			{
				ex.printStackTrace();
			}


			stage.close();
		});

		btnAddClose.setOnAction(e -> {
			stage.close();
		});
	}

	public void setMain(Main main) {
		this.main = main;
	}

	public void setStage(Stage stage) {
		this.stage = stage;
	}
}
