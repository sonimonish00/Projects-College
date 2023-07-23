import java.net.*;
import java.util.*;
public class Client {
	public static void main(String[] args) 
	{
	
		
		try {
			
			DatagramSocket client=new DatagramSocket();
			Scanner imp=new Scanner(System.in);
			String n=imp.next();
			byte msg[]= new byte[n.length()];
			msg=n.getBytes();
			InetAddress ip=InetAddress.getLocalHost();
			DatagramPacket dp = new DatagramPacket(msg, msg.length, ip, 3123); //Port : 3000, Host : LocalHost  
		    client.send(dp);
		   
		    DatagramSocket servermsg = new DatagramSocket(3100); 
		    byte[] buf = new byte[10];  
		    DatagramPacket dpclient = new DatagramPacket(buf,10);  
		    servermsg.receive(dpclient);  
		    System.out.println("Revieved to client :"+ new String (buf));
		   
		    
		} catch (Exception e) {
			System.out.println("Not Done..!!!");
		}
		
	}

}