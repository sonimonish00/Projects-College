import java.net.*;
import java.io.*;
import java.util.*;
public class Client {

	
	public static void main(String[] args) throws IOException {
		
			DatagramSocket client=new DatagramSocket();
			
			System.out.print("Enter the Numbers N You want to Sort : ");
			Scanner in=new Scanner(System.in);
			
			int n=in.nextInt();
			byte num[]= new byte[n+1];
			
			System.out.println("Enter the numbers you want to Send :");
			for(int i=0;i<n;i++)
			{
				num[i+1]=in.nextByte();
				num[0]++;
			}
			
			InetAddress ip=InetAddress.getLocalHost();
			DatagramPacket dp = new DatagramPacket(num, num.length,ip,3843);  
		    client.send(dp);
		    
		    client.close();
	
	}

}
