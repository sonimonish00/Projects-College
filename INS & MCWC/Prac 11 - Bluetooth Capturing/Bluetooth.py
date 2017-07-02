import bluetooth
import socket

target_name = "Galaxy J7"
target_address = None

print "performing inquiry..."
nearby_devices = bluetooth.discover_devices()
print "found %s devices" % nearby_devices

for bdaddr in nearby_devices:
    if target_name == bluetooth.lookup_name( bdaddr ):
        target_address = bdaddr
        break

if target_address is not None:
    print "found target bluetooth device with address ", target_address
else:
    print "could not find target bluetooth device nearby"

#bluesock= socket.socket(socket.AF_BLUETOOTH, socket.SOCK_STREAM, socket.BTPROTO_RFCOMM)
#bluesock.connect((target_address, 1))
