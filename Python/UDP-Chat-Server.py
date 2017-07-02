from socket import *   #for sockets
import sys
 
HOST = 'localhost'   # Symbolic name meaning all available interfaces
PORT = 8888 # Arbitrary non-privileged port
 
# Step 1 : Create Datagram (udp) socket
try :
    s = socket(AF_INET, SOCK_DGRAM)
    #print('Socket created')
except (error,msg):
    print('Failed to create socket. Error Code : ' + str(msg[0]) + ' Message ' + msg[1])
    sys.exit()
 
 
# Step 2 : Bind socket to local host and port
try:
    s.bind((HOST, PORT))
    #print('Socket bind complete')
except (error,msg):
    print('Bind failed. Error Code : ' + str(msg[0]) + ' Message ' + msg[1])
    sys.exit()
 
#now keep talking with the client
while 1:
    # receive data from client (data, addr)
    d = s.recvfrom(1024)
    data = d[0].decode()
    addr = d[1]
     
    if not data: 
        break
     
    reply = 'SERVER Says : ' + data
    s.sendto(reply.encode() , addr)
     
s.close()
