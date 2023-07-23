import java.net.*;
import java.io.*;

public class Server {
	public static void main(String[] args) throws IOException {
		    DatagramSocket ds = new DatagramSocket(3843); 
		    DatagramPacket dp = new DatagramPacket(buf,1024);  
		    
		    byte[] buf = new byte[1024];  
		    ds.receive(dp);  
		   
		    for(int i=1;i<=buf[0];i++)
		    {
		    	for(int j=1;j<buf[0];j++)
		    	{
		    		if(buf[j]>buf[j+1])
		    		{
		    		byte temp;
		    		temp=buf[j];
		    		buf[j]=buf[j+1];
		    		buf[j+1]=temp;
		    		}
		    	}
		    }
		    
		    for(int k=1;k<=buf[0];k++)
		    {
		    System.out.println(buf[k]);
		    }
		    ds.close();
	}

}
