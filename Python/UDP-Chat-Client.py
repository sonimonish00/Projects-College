"""
Develop the chat application using socket programming.
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

msg = input('Enter message to send."bye" to Exit -->  ')
while msg != 'bye':
    try :
        #Set the whole string
        s.sendto(msg.encode(), (host, port))
         
        # receive data from client (data, addr)
        d = s.recvfrom(1024)
        reply = d[0].decode()
        addr = d[1]
         
        print(reply)
        msg = input('Enter message to send."bye" to Exit -->  ')
        
    except (error,msg):
        print('Error Code : ' + str(msg[0]) + ' Message ' + msg[1])
        sys.exit()

s.close()