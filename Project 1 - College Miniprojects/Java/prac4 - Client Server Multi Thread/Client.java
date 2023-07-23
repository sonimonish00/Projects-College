import java.io.*;
import java.net.*;
public class Client {

	public static void main(String[] args)throws IOException {
		String sentence;
		String modifiedSentence;
		
		BufferedReader inFromUser =new BufferedReader(new InputStreamReader(System.in));
		Socket clientSocket = new Socket("localhost", 6888);
		DataOutputStream outToServer =new DataOutputStream(clientSocket.getOutputStream());
		
		BufferedReader inFromServer = new BufferedReader(new InputStreamReader(clientSocket.getInputStream()));
				
		sentence = inFromUser.readLine();
		outToServer.writeBytes(sentence + '\n');
		
		modifiedSentence = inFromServer.readLine();
		System.out.println("REVERSE FROM SERVER: " + modifiedSentence);
		clientSocket.close();
	}

}
