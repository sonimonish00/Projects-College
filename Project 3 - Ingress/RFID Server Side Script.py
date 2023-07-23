
#!/usr/bin/env python
# -*- coding: utf8 -*-

import RPi.GPIO as GPIO
import MFRC522
import signal
import MySQLdb
from wakeonlan import wol

continue_reading = True

# Capture SIGINT for cleanup when the script is aborted
def end_read(signal,frame):
    global continue_reading
    print "Ctrl+C captured, ending read."
    continue_reading = False
    GPIO.cleanup()

# Hook the SIGINT
signal.signal(signal.SIGINT, end_read)

# Create an object of the class MFRC522
MIFAREReader = MFRC522.MFRC522()


#Buzer setup
GPIO.setwarnings(False)

# Welcome message
print "Welcome to the Entry Management System"
print "Press Ctrl-C to stop."

# This loop keeps checking for chips. If one is near it will get the UID and authenticate
while continue_reading:
    
    # Scan for cards    
    (status,TagType) = MIFAREReader.MFRC522_Request(MIFAREReader.PICC_REQIDL)

    # If a card is found
    if status == MIFAREReader.MI_OK:
        print "Card detected"
    
    # Get the UID of the card
    (status,uid) = MIFAREReader.MFRC522_Anticoll()

    # If we have the UID, continue
    
    if status == MIFAREReader.MI_OK:
	
        # Print UID
        #print "Card read UID: "+str(uid[0])+","+str(uid[1])+","+str(uid[2])+","+str(uid[3])
    
        # This is the default key for authentication
        key = [0xFF,0xFF,0xFF,0xFF,0xFF,0xFF]
        
        # Select the scanned tag
        MIFAREReader.MFRC522_SelectTag(uid)

        # Authenticate
        
	status = MIFAREReader.MFRC522_Auth(MIFAREReader.PICC_AUTHENT1A, 8, key, uid)
	
        # Check if authenticated
        if status == MIFAREReader.MI_OK:
            MIFAREReader.MFRC522_Read(8)
            MIFAREReader.MFRC522_StopCrypto1()

	    code = str(uid[0])+str(uid[1])+str(uid[2])+str(uid[3])
            db = MySQLdb.connect("localhost","root","12345","rfid")
    	    cursor = db.cursor()
	    cursor.execute("select * from student_info where code='"+code+"'")
	    data = cursor.fetchone()
	    print "Hello, Student Your Enrolment is :%s"% data[1]
	    enrol = data[1]
	    print "Press ...."
	    print "1. Get Random Assigned PC."
	    print "2. Get Last Used PC(if available)"
	    ch = raw_input('Enter you Choice: ')
	    if(ch=='1'):
		#Random selection of PC
	    	c1 = db.cursor()
		
		c1.execute("select count(*) from in_use_pc where enrol= %s",(enrol))
		data1 = c1.fetchone()
	    	if data1[0]!=0:
	    		print "You have Alredy been assigned one PC.PLease Shutdown that PC to Use New PC."
			db.close()
			print "--------------------------------------------------------------------------------"
			print "Swipe Your RFID Card Here..."
		else:
				
			#selecting pc for assigning to user------------------------->	

			c2 = db.cursor()
		    	c2.execute("select * from not_use_pc")
	    		data2 = c2.fetchone()
			
			if data2 == None :
				print "No PC Available to Assign at this time."
			else:
				mac_id = data2[2]
				ip_address = data2[0]
				pc_number = data2[1]

			#Wake on lan logic starts here------------------------------------------------->
		

			wol.send_magic_packet(mac_id)
			print "You Have Assigned PC Number: %s"%pc_number
			print "--------------------------------------------------------------------------------"
			print "Swipe Your RFID Card Here..."
            	
			#intering entry of this assigned pc into in_use_pc table------------------------>

			try:
				c3 = db.cursor()
			   	c3.execute("insert into in_use_pc (mac_id,ip_address,enrol,pc_number) values (%s,%s,%s,%s)",(mac_id,ip_address,enrol,pc_number))
				db.commit()
			except:
				db.rollback()
				db.close()

			#deleting entry of assigned pc from not_use_pc table ---------------------------------->

			try:
				c4 = db.cursor()
	    			c4.execute("delete from not_use_pc where mac_id= %s",(mac_id))
				db.commit()
					
			except:
				db.rollback()
				db.close()

			#inserting entry into last_use pc table--------------------------------------->

			c41 = db.cursor()
	    		c41.execute("select * from last_use where enrol= %s",(enrol))
			data41 = c41.fetchone()
					
			if data41 == None:
				try:

					c42 = db.cursor()
		    			c42.execute("insert into last_use (mac_id,enrol) values(%s,%s)",(mac_id,enrol))
					db.commit()
				except:
					db.rollback()
					db.close()
			else:
				try:
					c42 = db.cursor()
		    			c42.execute("update last_use SET mac_id=%s,enrol=%s",(mac_id,enrol))
					db.commit()
				except:
					db.rollback()
					db.close()

	    elif(ch == '2'):
	    	#selection of PC in Serial manner ---------------------------------------->
	    	c5 = db.cursor()
		c5.execute("select count(*) from in_use_pc where enrol= %s",(enrol))
		data5 = c5.fetchone()
	    	if data5[0]!=0:
	    		print "You have Alredy been assigned one PC.PLease Shutdown that PC to Use New PC."
			db.close()
			print "--------------------------------------------------------------------------------"
			print "Swipe Your RFID Card Here..."
		else:
				
			#selecting pc for assigning to user------------------------->	
			
			c61 = db.cursor()
		    	c61.execute("select * from last_use where enrol=%s",(enrol))
	    		data61 = c61.fetchone()
			if data61 == None:
				print "Your First Time User Choose Option 1"
			else:
				mac_id1 = data61[0]

			c6 = db.cursor()
		    	c6.execute("select * from not_use_pc where mac_id=%s",(mac_id1))
	    		data6 = c6.fetchone()
			
			if data6 == None :
				print "No PC Available to Assign at this time."
			else:
				ip_address1 = data6[0]
				pc_number1 = data6[1]

			#Wake on lan logic starts here------------------------------------------------->
		

			wol.send_magic_packet(mac_id1)
			print "You Have Assigned PC Number: %s"%pc_number1
            	
			#intering entry of this assigned pc into in_use_pc table------------------------>

			try:
				c7 = db.cursor()
			   	c7.execute("insert into in_use_pc (mac_id,ip_address,enrol,pc_number) values (%s,%s,%s,%s)",(mac_id1,ip_address1,enrol,pc_number1))
				db.commit()
			except:
				db.rollback()
				db.close()

			#deleting entry of assigned pc from not_use_pc table ---------------------------------->

			try:
				c8 = db.cursor()
	    			c8.execute("delete from not_use_pc where mac_id= %s",(mac_id1))
				db.commit()
					
			except:
				db.rollback()
				db.close()
	else:
		print "Authentication Error"
	
	    	