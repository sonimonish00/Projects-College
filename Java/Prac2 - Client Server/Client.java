import java.net.*;
import java.io.*;
public class Client {
	public static void main(String[] args)throws Exception {
		Socket sock = new Socket("127.0.0.1",3843);
	    byte[] mybytearray = new byte[1024];
	    InputStream is = sock.getInputStream();
	    FileOutputStream fos = new FileOutputStream("e:/c.txt");
	    BufferedOutputStream bos = new BufferedOutputStream(fos);
	    int bytesRead = is.read(mybytearray,0,mybytearray.length);
	    bos.write(mybytearray, 0, bytesRead);
	    bos.close();
	    sock.close();
	}

}
