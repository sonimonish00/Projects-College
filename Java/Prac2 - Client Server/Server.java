import java.net.*;
import java.io.*;

public class Server {
	public static void main(String[] args)throws IOException {
		ServerSocket servsock = new ServerSocket(3843);
	    File myFile = new File("E:/abc.txt");
	    while (true) {
	      Socket sock = servsock.accept();
	      byte[] mybytearray = new byte[(int) myFile.length()];
	      BufferedInputStream bis = new BufferedInputStream(new FileInputStream(myFile));
	      bis.read(mybytearray, 0, mybytearray.length);
	      OutputStream os = sock.getOutputStream();
	      os.write(mybytearray, 0, mybytearray.length);
	      os.flush();
	      sock.close();
	}
  }
}
