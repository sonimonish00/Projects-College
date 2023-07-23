<!DOCTYPE html>

<!--[if lt IE 7 ]>
<html class="ie ie6" lang="en">
   <![endif]-->
   <!--[if IE 7 ]>
   <html class="ie ie7" lang="en">
      <![endif]-->
      <!--[if IE 8 ]>
      <html class="ie ie8" lang="en">
         <![endif]-->
         <!--[if (gte IE 9)|!(IE)]><!-->
         <html lang="en">
            <!--<![endif]-->

            

            
<title>Line Follower bot | Powerfest - Techfest 2016</title>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
    <meta name="apple-mobile-web-app-capable" content="yes" />    
      <meta name="description" content="POWERFEST 2016: GPERI's Biggest Technology Festival">
      <meta name="keywords" content="gperi,powerfest 2016,techfest 2016,Mehsana,mevad,gujarat,power,engineering,research,institute,actions,cultivate,intellect,
      GPCL,Government,level,zonal,national,India,Asia,biggest,Festival,entertainment,2K16,creative,competitive,civil,computer,mechanical,electrical,
      LAN gaming,Counter Strike,Robo race,robo war,autocad,circuit tweaks,quiz ball,model making,technical,poster making,3D,
      2D,coding,development,dark,android,catch the flag,techfest 2k16"/>
      <meta name="viewport" content="width=device-width, initial-scale=1">
      <meta http-equiv="cache-control" content="public" />
             <meta name="viewport" content="width=device-width, initial-scale=1">
             <meta http-equiv="expires" content="Mon, 1 Aug 2016, 23:59:00 GMT" />
           



    <link rel="stylesheet" href="../../cdnjs.cloudflare.com/ajax/libs/font-awesome/4.3.0/css/font-awesome.min.css">

 

    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
  <link href='https://fonts.googleapis.com/css?family=RobotoDraft:400,500,700,400italic' rel='stylesheet' type='text/css'>

  

      <link rel="stylesheet" href="../../maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css">

     <script src="../../cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js"></script>  

     
    <link rel="stylesheet" href="../../cdnjs.cloudflare.com/ajax/libs/materialize/0.97.0/css/materialize.min.css">

  

              <link rel="stylesheet" type="text/css" href="css/style.css">

              <style type="text/css">

            

              .segment-heading {
                color: #045E83;} 
 

              h1, h2, h3, h4, h5, h6 {
                color: #045E83 ;
              }

              a {
                color:  #045E83 ;
              }

              .card-action > a {
                color:  #045E83 ;
              }

              .btn-custom {
                background-color: #045E83 ;
              }

              .btn-custom:hover {
                background-color: #045E83 ;
              }




              </style>    

              <!-- Google Analytics -->

            <script>
  (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
  (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
  m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
  })(window,document,'script','//www.google-analytics.com/analytics.js','ga');

  ga('create', 'UA-72209071-1', 'auto');
  ga('send', 'pageview');

</script>    

  </head>

  <body>

    <div class="menu-overlay"></div>    
      
      <div id="wrap">  

      <style type="text/css">

  #sidenav-2 {
    width: inherit;
  }

  .slide-out {
margin-left: 20px;
}

.side-nav-li{
  margin-left: 0px;
  margin-right: 0px;
  padding-right: 41px;
  padding-left: 41px;
}
.fa{
    font-size: 25px;
  }
.glyphicon{
    font-size: 25px;
  }

  </style>
<?php include("../../includes/nav.html"); ?>

            <div id="bar" class="navbar-fixed-top" style="top:0;background-color: #f39c12"; >
               
                  <div id="nav" style="float:left;">
                    <style type="text/css">  

 li ul {
        padding: 0;
    }   

 /*   .glyphicon-align-justify {
        padding-top: 18px;
        vertical-align: center;
        text-align: center;
        background-color: none;
        width: 70px;
        color: white;
        height :70px;
        font-size: 22px;
    }*/

    .nav-segment {
        position:relative;
        /*padding-left: 30px;
        padding-top: 20px; */
        width : 200px;
        background-color: black;
        font-size: 20px;
        color: #fff;
        height: 60px;
    }



.four {
  margin-bottom: 30px;
}
@media  screen and (min-width: 720px) {
  .four {
    margin: 0;
    float: left;
    width: 33.33333%;
  }
}

@media  screen and (min-width: 720px) {
  .eight {
    margin: 0;
    float: left;
    width: 66.66667%;
  }
}

ul {
  list-style: none;
  margin: 0;
  padding: 0;
}

nav {
  position: fixed;
  top: 0;
  left: 0;
  right: 0;
  background: #00bcd4;
  height: 68px;
  font-size: 16px;
  color: #fff;
  box-shadow: 0 2px 5px rgba(0, 0, 0, 0.26);
  z-index: 5;
}
@media  screen and (min-width: 720px) {
  nav {
    font-size: 24px;
  }
}
nav ul {
  line-height: 68px;
}
nav ul li {
  float: left;
  padding: 0 15px;
}
nav span {
  display: inline-block;
  position: relative;
  margin: 0 15px;
  top: -2px;
}
@media  screen and (min-width: 720px) {
  nav span {
    top: -3px;
  }
}
nav span:after {
  content: '';
  display: inline-block;
  width: 7px;
  height: 7px;
  border-top: 2px solid #fff;
  border-right: 2px solid #fff;
  -webkit-transform: rotate(45deg);
      -ms-transform: rotate(45deg);
          transform: rotate(45deg);
}
@media  screen and (min-width: 720px) {
  nav span:after {
    width: 9px;
    height: 9px;
  }
}

/*.menu-icon {
  position: relative;
  width: 48px;
  margin-top: 13px;
}*/

.menu-icon:before {
  content: '';
  position: absolute;
  width: 36px;
  height: 36px;
  top: -24px;
  left: 0;
  cursor: pointer;
  z-index: 1;
}
.menu-icon div {
  position: relative;
  background: #015F6B;
  width: 18px;
  height: 2px;
}
.menu-icon div:before, .menu-icon div:after {
  content: '';
  position: absolute;
  height: 2px;
  width: 100%;
  background: #015F6B;
}
.menu-icon div:before {
  top: -5px;
}
.menu-icon div:after {
  bottom: -5px;
}

.menu-icon:before {
  content: '';
  position: absolute;
  width: 36px;
  height: 36px;
  top: -24px;
  left: 0;
  cursor: pointer;
  z-index: 1;
}
.menu-icon div {
  position: relative;
  background: #015F6B;
  width: 18px;
  height: 2px;
}
.menu-icon div:before, .menu-icon div:after {
  content: '';
  position: absolute;
  height: 2px;
  width: 100%;
  background: #015F6B;
}
.menu-icon div:before {
  top: -5px;
}
.menu-icon div:after {
  bottom: -5px;
}

.side-nav {
  position: fixed;
  top: 0;
  left: 0;
  bottom: 0;
  width: 240px;
  background: #fff;
  z-index: 10;
  overflow-y: auto;
  -webkit-transform: translate3d(-240px, 0, 0);
          transform: translate3d(-240px, 0, 0);
  -webkit-backface-visibility: hidden;
          backface-visibility: hidden;
  -webkit-transform-style: preserve-3d;
          transform-style: preserve-3d;
  -webkit-transition: -webkit-transform 0.25s cubic-bezier(0.55, 0, 0.1, 1);
          transition: transform 0.25s cubic-bezier(0.55, 0, 0.1, 1);
  border-right: 1px solid rgba(0, 0, 0, 0.14);
}
.side-nav.active {
  -webkit-transform: translate3d(0, 0, 0);
          transform: translate3d(0, 0, 0);
}
.side-nav header {
  border-bottom: 1px solid #eee;
}
.side-nav header h1 {
  margin: 0;
  font-family: Georia, serif;
  color: #bdbdbd;
  letter-spacing: -0.05rem;
}
.side-nav footer {
  padding-top: 30px;
  padding-bottom: 30px;
  border-top: 1px solid #eee;
}
.side-nav footer h5 {
  margin: 0 0 10px 0;
}
.side-nav footer h5 a {
  color: #0277bb;
}

.side-nav li {
  font-weight: normal;
  text-align: left;
}
.side-nav ul {
  height: auto;
}
.side-nav ul li {
  font-size: 13px;
/*  font-weight: bold;*/
}
.side-nav ul li a {
  display: block;
/*  font-weight: bold;*/
  color: #333;
  padding: 15px 0;
}

.collapsible-body li {
  font-weight: normal;
}

.menu-overlay {
  position: fixed;
  top: 0;
  left: 0;
  right: 0;
  background: rgba(0, 0, 0, 0.5);
  z-index: 1040;
  -webkit-transform: translateZ(0);
          transform: translateZ(0);
  -webkit-transition: all 0.45s cubic-bezier(0.55, 0, 0.1, 1);
          transition: all 0.45s cubic-bezier(0.55, 0, 0.1, 1);
  -webkit-backface-visibility: hidden;
          backface-visibility: hidden;
}
.menu-overlay.active {
  width: 100%;
  height: 100%;
}

@-webkit-keyframes slideIn {
  0% {
    -webkit-transform: translate3d(-100%, 0, 0);
            transform: translate3d(-100%, 0, 0);
  }
  20% {
    -webkit-transform: translate3d(0, 0, 0);
            transform: translate3d(0, 0, 0);
  }
  80% {
    -webkit-transform: translate3d(0, 0, 0);
            transform: translate3d(0, 0, 0);
  }
  90% {
    -webkit-transform: translate3d(-100%, 0, 0);
            transform: translate3d(-100%, 0, 0);
  }
  100% {
    -webkit-transform: translate3d(-100%, 0, 0);
            transform: translate3d(-100%, 0, 0);
  }
}

@keyframes  slideIn {
  0% {
    -webkit-transform: translate3d(-100%, 0, 0);
            transform: translate3d(-100%, 0, 0);
  }
  20% {
    -webkit-transform: translate3d(0, 0, 0);
            transform: translate3d(0, 0, 0);
  }
  80% {
    -webkit-transform: translate3d(0, 0, 0);
            transform: translate3d(0, 0, 0);
  }
  90% {
    -webkit-transform: translate3d(-100%, 0, 0);
            transform: translate3d(-100%, 0, 0);
  }
  100% {
    -webkit-transform: translate3d(-100%, 0, 0);
            transform: translate3d(-100%, 0, 0);
  }
}
@-webkit-keyframes fadeIn {
  0% {
    opacity: 0;
  }
  20% {
    opacity: 1;
  }
  80% {
    opacity: 1;
  }
  90% {
    opacity: 0;
  }
  100% {
    opacity: 0;
  }
}
@keyframes  fadeIn {
  0% {
    opacity: 0;
  }
  20% {
    opacity: 1;
  }
  80% {
    opacity: 1;
  }
  90% {
    opacity: 0;
  }
  100% {
    opacity: 0;
  }
}


#nav-toggle { 
  cursor: pointer; 
  position: absolute;
  top: 14px;
  left: 20px;
/*  padding: 10px 35px 16px 0px; */
}

#nav-toggle span, #nav-toggle span:before, #nav-toggle span:after {
  cursor: pointer;
  border-radius: 1px;
  height: 5px;
  width: 35px;
  background: white;
  position: absolute;
  display: block;
  content: '';
}
#nav-toggle span:before {
  top: -10px; 
}
#nav-toggle span:after {
  bottom: -10px;
}

#nav-toggle span, #nav-toggle span:before, #nav-toggle span:after {
  transition: all 500ms ease-in-out;
}
#nav-toggle.active span {
  background-color: transparent;
}
#nav-toggle.active span:before, #nav-toggle.active span:after {
  top: 0;
}
#nav-toggle.active span:before {
  transform: rotate(45deg);
}
#nav-toggle.active span:after {
  transform: rotate(-45deg);
}

#hamburger-span {
  padding: 14.5px 17px;
}

#header-title {
  position: absolute;
  top: 8.5px;
  left: 8%;
}




   

</style>

 <script type="text/javascript">

// document.querySelector( "#nav-toggle" )
//   .addEventListener( "click", function() {
//     this.classList.toggle( "active" );
//   });

// </script>



  <div class="" style="display:inline-block;">

    <a href="#" id="nav-toggle" data-activates="slide-out" class="button-collapse">

          <!-- <span></span>        

         <i class="fa fa-bars" id="hamburger-span"></i> -->

         <i class="menu-icon" id="hamburger-span">
              <span></span>
            </i>
          </a>
      
            <!-- <i class="fa fa-bars">
              <span></span>
            </i>
          </a>
 -->

     

  </div>

  <div class="" id="page-head" style="display:inline-block;">

  <h5 style="color:#FFFFFF;" id="header-title">
    Line Follower Bot          
       

      </h5>

  </div>

  <div class="hidden-xs" style="float:right;" style="display:inline-block;">

    <a href="http://powerfest.gperi.ac.in/index.php">


      <img src=

      "../images/tflogos/compi2.png" 



      width="170px" style="margin-top:15px;margin-right:7px;" height="inherit">

    </a>

  </div>








 

  </script>



                  </div>       


              </div>



              <div id="ajax_area">
                <!--  <img src="../images/arrow.png" style="left:20px;top:190px;"> 
       -->
                
<style type="text/css">	
.contact-group{
  padding-left: 0px;

}
#segment-cover {
	background-image: url('../images/competitions/competitions_bg.jpg');
	background-size: 100% 300px;
	background-repeat: no-repeat;
}

/*.btn-custom {
	width: 200px;
	text-align: center;
	padding: 0;
	background-color: #1976D2 ;
	color: #fff;

}

.btn-custom:hover {
	color: #fff;
	background-color: #1976D2  ;
}

*/

</style>



<div id="segment-cover" style="z-index:-10;">

	<section class="content-wrap container-fluid" style="z-index:0;">
<div class="z-depth-1 content-wrap-shadow" style="height:auto;">

    
	<div class="white-area">

		<img class="segment-img-small" src="../pics/general/line.jpg" alt="img11"/>

		<div class="segment-content-desc">

	<h5>Line Follower Bot</h5>
	<div align="justify">
		<p style="color:black;">The objective of this competition is to make a robot  that can follow a Track indicated by black lines on a white background and reach the finishing point of the track as fast as possible. Thus, the robot shall start from the START point and reach the FINISH point by following the black lines.The black line of the Track  shall be 4 cm in width. The minimum radius of curvature of the Black line Track shall be 5 cm.
		</p>
		</div></div>

		

	</div>

  <br>
	<section class="button-contact">

		<table class="centered responsive-table hidden-xs">

		
	</table>

	<div class="hidden-md hidden-lg hidden-sm">

		<tr>
        
        <td><a class="waves-effect waves-light btn-custom btn" style="background-color:#f57f17; height:80px; width:250px "><span class="glyphicon glyphicon-flag"></span>Prize Worth More than :<br>Rs. 17000</a></td>
        <br><br>
        <td><a class="waves-effect waves-light btn-custom btn" href="../gen_line.php" target="_blank">REGISTER</a></td>
      </tr>

	</div>
<ul class="collapsible" data-collapsible="accordion">
    <li>
      <div class="collapsible-header">RULES OF EVENT</div>
      <div class="collapsible-body">
      <p><ol>    
<li>The line follower robot should ONLY consist of the following components:</li>
<li>1). Two Plastic Wheels.</li>
<li>2). One Castor Wheel.</li>
<li>3). AT89C51 or AT89S51 only should be used for autonomously operating the robot. No other microcontroller should be used. Robots using other microcontrollers shall be disqualified.</li>
<li>4). Maximum  6 numbers of IR sensors should be used (bonus points for less number of IR sensors shall be given   as per the Rule No. 4 mentioned above). Here IR sensor means one module consisting of an IR Diode and its Receiver along with supporting electronic components.
<li>5). The electric motors to be used shall be either DC motors or Servo Motors or Stepper motors Coupled with a gear box if needed. The chassis of the robot should not be ready made. A suitable Motor driver e.g IC L293 etc, can be used. Other electronic components like LEDs, Diodes, Resistors,Capacitors, Push Button switch, SPDT switches,DPDT switches, Transistors, MosFets, Heat Sinks, Crystal Oscillators, Potentiometers,etc. are allowed.</li>
<li>6). All the teams participating in this competition shall compulsorily bring a list of all the components used in their robot.The component list will be matched with the components on their robot. No discrepancy shall be allowed.</li>
<li>7). The power supply of the motor should be from DC batteries, mounted on the  platform of the robot.</li>
<li>8). Maximum dimensions of the robot: Length * Width * Height = 20 cm * 16 cm * 16 cm.</li>
<li>9). The PCB of the robot should be designed by the team (fabrication of the PCB can be done outside) and should NOT be ready made/ Custom Made/ purchased from the market. ( the organizers have a well maintained database of such robots & robotic kits available in the market,so any such "ready made" robot shall be disqualified).The maximum time for a try shall not exceed 5 Minutes. No touch shall be allowed after starting the robot on the black line track arena. If the robot wonders off the Black line track arena, one try shall be deducted and the robot can start again.There are maximum 3 trials for each robot. Best time of the 3 trials shall be counted. A team should consist of maximum 3 team members.</li>

</ol></p>    

      </div>
</li>
<li>
      <div class="collapsible-header">EVALUATION CRITERIA</div>
      <div class="collapsible-body">
<p><ol>    
<li>The winning Robot will be the one with maximum number of points. The point calculation shall be as per the following rules:</li>
<li><strong>Rule No. 1</strong> - The Robot that successfully completes the Track from start to finish, shall get 100 points.</li>
<li><strong>Rule No. 2</strong> - After fulfilling the above condition (i.e Rule no. 1) : Depending on the time taken to complete the track the team shall get additional points= (300- Best time in seconds to finish the complete track).</li>
<li><strong>Rule No. 3</strong> - 20 Bonus Points for Each IR sensor NOT USED. It is expected to use less number of IR sensors as possible.</li>
<li>For example: Team A uses 3 IR sensors,Team B uses 2 IR sensors and Team C uses 1 IR sensor then, Team C gets a Bonus of 20+20= 40 points. Team B gets a Bonus of 20 points.Here IR sensor means one module consisting of an IR Diode and its Receiver along with supporting electronic components only. These bonus points shall be awarded only if Rule No. 1 is fulfilled.</li>
<li><strong>Rule No. 4</strong> - In case of two or more teams having equal no. of points, The teams shall be ranked as per the time taken to complete the track, considering their best time of the 3 trials Even then, if there is a tie, then the concerned teams shall run their robots on the same track but in reverse direction and they shall be ranked as per Rule no. 1,2 and 3, mentioned above.</li>
</ol></p> 


      </div>
  
    </li>
    
 <li>
      <div class="collapsible-header">ELIGIBILITY CRITERIA</div>
      <div class="collapsible-body">
  <p>
  	The robot has to be completely autonomous i.e it should operate on its own once started and follow the black line path from the starting point upto the finishing point without any form of external guidance. If any form of external guidance is found, the concerned robot and team shall be disqualified.
  </p>
 
</div>
    </li>
   
     <li>
      <div class="collapsible-header">TEAM REQUIREMENT</div>

      <div class="collapsible-body">
        <p>A team should consist of maximum 3 team members.</p>
        </div>

    </li>
       <li>
      <div class="collapsible-header">EVENT FEES</div>

      <div class="collapsible-body">
        <p>50 RS. per person.</p>
        </div>

    </li>

  </ul>
<table class="centered responsive-table hidden-xs">

    <tbody>
      <tr>
        
        <td><a class="waves-effect waves-light btn-custom btn" style="background-color:#f57f17; height:80px; width:250px "><span class="glyphicon glyphicon-flag"></span>Prize Worth More than :<br>Rs. 17000</a></td>
        <td><a class="waves-effect waves-light btn-custom btn" href="../gen_line.php" target="_blank">REGISTER</a></td>
      </tr>

    </tbody>
  </table>
	<p class="query-paragraph">For further queries contact:</p>

<table class="query-paragraph">
    <tr>
    <td><pre><b>Faculty Co-Ordinator :</b><br>Prof. Dhaval R. Patel<br>7698444407</pre></td><td></td><td></td></tr>
    <tr><td><pre><b>Student Co-Ordinator :</b><br>KANSARA KUSHAL<br>9624653417</pre></td><td></td><td></td></tr>
    
</table>


	</section>

	




    </div>

	</section>


</div>

<script>
  $(document).ready(function (){
            $(".collapsible-header").click(function (){
                //$(this).animate(function(){
                    $('html, body').animate({
                        scrollTop: $(".collapsible").offset().top
                    }, 500);
                //});
            });
        }); 
</script>

              </div>

      </div>  
              

        <?php include("../../includes/footer-event.html"); ?>
            
            <script src="../../maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>
            
            <script src="../../cdnjs.cloudflare.com/ajax/libs/materialize/0.97.0/js/materialize.min.js"></script>


  <script src="../../cdnjs.cloudflare.com/ajax/libs/modernizr/2.8.3/modernizr.min.js"></script>
  
  <script src="../../cdnjs.cloudflare.com/ajax/libs/pace/1.0.2/pace.min.js"></script>


            

            <script type="text/javascript">

                    var sidenav = $('.side-nav');
                    var menuOverlay = $('.menu-overlay');

                    $('.menu-icon').click(function() {
                        $(sidenav).addClass('active');
                        $(menuOverlay).addClass('active');
                    });

                    $('.menu-overlay').click(function() {
                        $(sidenav).removeClass('active');
                        $(this).removeClass('active');
                    });

             </script> 

             


            <!-- // <script src="js/pace.js"></script>
            // <script src="js/hover_js.js"></script> -->
      
  </body>
