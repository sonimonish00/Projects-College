# Ingress
Ingress - RFID Based Entry Management System

# About Ingress

In this Project we have connected a RFID reader with raspberry pi a Single board computer which is our base of our Server fulfilling the purpose of both Interacting with RFID tag as well as the Client Side request. When the RFID tag is swiped on RFID
reader, which is connected to Raspberry PI. It takes the Unique ID of the RFID Tag as an Input which is bind with the Enrollment no. and identifies the User and allocate the System to User. Then the User is allocated the PC and the PC is boot via LAN Boot,
and the system shows the client software on it which automatically allocates the enrollment no. of the user and asks for the password.

# Structure of Source Code

1. Front End : <br/> 
  A. Client Side Software (C#.NET) <br/> 
    <ul>Managing the the Login System and Enabling/Disabling the Control Panel.</ul><br/>
    <ul>Admin Panel Software - To Manage the Administrative Work for Maintaining Users for PC Allocation.</ul><br/> 

2. Back End : <br/> 
  B. Server Side Software (Python & MySQL DB) <br/>
    <ul>Server Side Script Loaded into Raspberry PI SD Card (DB and Web Server) interacts with Client Side Software.</ul><br/>
