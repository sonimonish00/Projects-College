import java.util.*;
import java.net.*;

public class Server{  
	  public static void main(String[] args) throws Exception { 

		  try{
			
	    DatagramSocket ds = new DatagramSocket(3123); 
	    byte[] buf = new byte[10];
	    DatagramPacket dp = new DatagramPacket(buf,10);  
	    ds.receive(dp);  

	    System.out.println("Recive to server : "+new String(buf));
	    
	    
	    DatagramSocket reply=new DatagramSocket();
		Scanner imp=new Scanner(System.in);
		String n=imp.next();
		byte msg[]= new byte[n.length()];
		msg=n.getBytes();
		InetAddress ip=InetAddress.getLocalHost();
		DatagramPacket dpreply = new DatagramPacket(msg, msg.length, ip, 3100);//Port : 3000, Host : LocalHost  
	    reply.send(dpreply);
	 
		}
		catch (Exception e) {
			System.out.println("Not Done..!!!");
	      }  

	  }
	}