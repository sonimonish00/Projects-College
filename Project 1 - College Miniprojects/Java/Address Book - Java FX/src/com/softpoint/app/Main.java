package com.softpoint.app;

import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

import com.softpoint.app.model.Contact;

import javafx.application.Application;
import javafx.stage.Stage;
import javafx.stage.StageStyle;
import javafx.scene.Scene;
import javafx.scene.layout.AnchorPane;
import javafx.fxml.FXMLLoader;


public class Main extends Application {
	private Stage window;

	private List<Contact> contancts = null;

	@Override
	public void start(Stage primaryStage) {
		try {
			this.window = primaryStage;

			initMain();

			this.window.show();
		} catch(Exception e) {
			e.printStackTrace();
		}
	}

	private void initMain() {
		try {
			contancts = new ArrayList<>();
			FXMLLoader loader = new FXMLLoader();
			loader.setLocation(this.getClass().getResource("view/Main.fxml"));
			AnchorPane root = (AnchorPane) loader.load();
			MainController controller = loader.getController();
			controller.setMain(this);
			controller.setContancts(contancts);
			Scene scene = new Scene(root);
			window.setScene(scene);
			window.initStyle(StageStyle.UNDECORATED);
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

	}

	public void initAdd() {
		try {
			FXMLLoader loader = new FXMLLoader();
			loader.setLocation(this.getClass().getResource("view/Add.fxml"));
			AnchorPane root = (AnchorPane) loader.load();
			AddController controller = loader.getController();
			controller.setMain(this);

			Scene scene = new Scene(root);

			Stage stage = new Stage();
			stage.initOwner(window);

			controller.setStage(stage);

			stage.setScene(scene);
			stage.initStyle(StageStyle.UNDECORATED);
			stage.showAndWait();

		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

	}

	public static void main(String[] args) {
		launch(args);
	}

	public List<Contact> getContancts() {
		return contancts;
	}
}
