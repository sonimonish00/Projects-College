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
 
#Keeping Infinte Loop
while 1:
    # receive data from client (data, addr)
    d = s.recvfrom(1024)
    data = d[0].decode()
    addr = d[1]
    print("Client's Detail: "+str(addr))
    #Checking if Null Data is not Recieved from Client
    if not data: 
        break
    print("Echoing Back The Data to Client From this ECHO Server ")
    reply = 'Welcome Client: The Message I Recieved from You is :-  ' + data
    #Echoing Back Through Server
    s.sendto(reply.encode() , addr)
    #print('Message[' + addr[0] + ':' + str(addr[1]) + '] - ' + data.strip())
     
s.close()
