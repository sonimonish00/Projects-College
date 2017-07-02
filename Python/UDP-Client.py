"""
Write UDP socket program to demonstrate the echo server functionality.
"""
from socket import *   #for sockets
import sys  #for exit
 
# creating udp socket
try:
    s = socket(AF_INET,SOCK_DGRAM)
except(error,msg):
    print('Failed to create socket')
    sys.exit()
 
host = 'localhost';
port = 8888;


try :
	msg = input('Enter message to send : ')
	#Set the whole string
	s.sendto(msg.encode(), (host, port))

	# receive data from client (data, addr)
	d = s.recvfrom(1024)
	reply = d[0].decode()
	addr = d[1]
	print("The Address of Server is :- "+str(addr))
	print('Server reply : ' + reply)

except(error,msg):
	print('Error Code : ' + str(msg[0]) + ' Message ' + msg[1])
	sys.exit()
