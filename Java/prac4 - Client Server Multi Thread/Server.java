import java.io.*;
import java.net.*;
public class Server {

	public static void main(String[] args)throws IOException {
		
		
		ServerSocket welcomeSocket = new ServerSocket(6888);
		
		while(true) {
		Socket connectionSocket = welcomeSocket.accept();
		
		new ServerThread(connectionSocket).start();
		
		
			}

}
	
}

