package com.softpoint.app;

import java.net.URL;
import java.util.List;
import java.util.ResourceBundle;
import java.sql.*;

import com.mysql.fabric.Server;
import com.softpoint.app.model.Contact;

import javafx.application.Platform;
import javafx.beans.value.ChangeListener;
import javafx.beans.value.ObservableValue;
import javafx.collections.FXCollections;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.ListCell;
import javafx.scene.control.ListView;
import javafx.util.Callback;

public class MainController implements Initializable{

	@FXML
	private Button btnClose;
	@FXML
	private ListView<Contact> listContacts;
	@FXML
	private Label lblName;
	@FXML
	private Label lblMobile;
	@FXML
	private Label lblEmail;
	@FXML
	private Button btnAdd;


	private Main main;

	private List<Contact> contancts;


	public MainController() {
		// TODO Auto-generated constructor stub

	}
	@Override
	public void initialize(URL location, ResourceBundle resources) {
		// TODO Auto-generated method stub

		btnClose.setOnAction(e -> {
			Platform.exit();
		});


		listContacts.setCellFactory(new Callback<ListView<Contact>, ListCell<Contact>>() {


			@Override
			public ListCell<Contact> call(ListView<Contact> param) {
				return new ListCell<Contact>(){
					@Override
					protected void updateItem(Contact item, boolean empty) {
						super.updateItem(item, empty);

						if(item != null){
							setText(item.getName());
						}
					}
				};
			}
		});

		/*listContacts.getSelectionModel().selectedItemProperty().addListener(new ChangeListener<Contact>() {
			@Override
			public void changed(ObservableValue<? extends Contact> observable, Contact oldValue, Contact newValue) {
				// TODO Auto-generated method stub
				if(newValue != null){
					lblName.setText(newValue.getName());
				}
			}
		});*/

		listContacts.getSelectionModel().selectedItemProperty().addListener((o, oldVal, newVal) -> {
			if(newVal != null){
				lblName.setText(newVal.getName());
				lblMobile.setText(newVal.getMobile());
				lblEmail.setText(newVal.getEmail());
			}
		});

		btnAdd.setOnAction(e -> {
			main.initAdd();

			this.contancts = main.getContancts();
			listContacts.setItems(FXCollections.observableArrayList(contancts));
		});
	}

	public void setMain(Main main) {
		this.main = main;


	}
	public void setContancts(List<Contact> contancts) {
		this.contancts = contancts;

		contancts.add(new Contact("Chirag", "chirag26@hotmail.com", "98898998989", ""));
		contancts.add(new Contact("Chirag2", "chirag26@hotmail.com", "98898998989", ""));
		contancts.add(new Contact("Chirag3", "chirag26@hotmail.com", "98898998989", ""));
		contancts.add(new Contact("Chirag4", "chirag26@hotmail.com", "98898998989", ""));
		contancts.add(new Contact("Chirag5", "chirag26@hotmail.com", "98898998989", ""));
		contancts.add(new Contact("Chirag6", "chirag26@hotmail.com", "98898998989", ""));


		try{
			Class.forName("com.mysql.jdbc.Driver");
			Connection  con=DriverManager.getConnection
                    ("jdbc:mysql://localhost:3306/AddressBook?useSSL=false","root","");
         String queryDB = "select * from contact";
         ResultSet rs = null;
       Statement sd = con.createStatement();
       rs = sd.executeQuery(queryDB);
       if(rs.next())
       {
    	   String name = rs.getString(1);
    	   String Mobile = rs.getString(2);
    	   String email = rs.getString(3);

    	   contancts.add(new Contact(name, email,Mobile, ""));

       }

		}
		catch(Exception ex)
		{
			ex.printStackTrace();
		}

		listContacts.setItems(FXCollections.observableArrayList(contancts));
	}
}
