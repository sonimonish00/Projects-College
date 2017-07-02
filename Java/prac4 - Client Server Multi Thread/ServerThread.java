import java.io.*;
import java.net.*;
public class ServerThread extends Thread {
	Socket socket;
	ServerThread(Socket socket)
	{
		this.socket=socket;
	}
	public void run(){
		try{
			String clientSentence;
			StringBuffer reverse; 
			
			/*
			String message = null;
			BufferedReader br = new BufferedReader(new InputStreamReader(socket.getInputStream()));
			while((message=br.readLine())!=null)
			{
				System.out.println("incoming Client Message:" +message);
			}*/
			
			BufferedReader inFromClient = new BufferedReader(new
					InputStreamReader(socket.getInputStream()));
					DataOutputStream outToClient =new DataOutputStream(socket.getOutputStream());
							
					
					clientSentence = inFromClient.readLine();
					StringBuffer str = new StringBuffer(clientSentence);
			        reverse = str.reverse();
					
			        
			        outToClient.writeBytes(reverse.toString() + '\n');
			        //welcomeSocket.close();
			}
		catch(IOException e)
		{
			e.printStackTrace();
			
		}
		
	}

}
