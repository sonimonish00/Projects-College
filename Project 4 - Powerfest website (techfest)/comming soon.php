
<!DOCTYPE HTML>
<!--[if lt IE 7 ]> <html lang="en" class="ie ie6"> <![endif]--> 
<!--[if IE 7 ]>	<html lang="en" class="ie ie7"> <![endif]--> 
<!--[if IE 8 ]>	<html lang="en" class="ie ie8"> <![endif]--> 
<!--[if IE 9 ]>	<html lang="en" class="ie ie9"> <![endif]--> 
<!--[if !IE]><!--> <html lang="en"> <!--<![endif]-->
<head>
<meta charset="utf-8">
<title>Powerfest 2K16 | GPERI</title>
<meta name="description" content="">
<meta http-equiv="X-UA-Compatible" content="chrome=1">
<link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=PT+Sans+Narrow:regular,bold"> 
<link rel="stylesheet" type="text/css" href="css/comming/bootstrap.min.css">
<link rel="stylesheet" type="text/css" href="css/comming/styles.css">
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js"></script>
        <link rel="stylesheet" href="//netdna.bootstrapcdn.com/bootstrap/3.0.0/css/bootstrap.min.css">
        <script type="text/javascript" src="js/comming/TimeCircles.js"></script>
        <link rel="stylesheet" href="js/comming/TimeCircles.css" />


</head>

<body id="home">
<section class="main">
<div id="Content" class="wrapper topSection">
	<div id="Header">
	<div class="wrapper">
		<div class="logo"><h1><img src="images/comming/logo1.png"   style="height:150px; width:150px; padding:10px" />Powerfest 2K16 <br></h1><h3>
															Gujarat Power Engineering and <br>
															Research Institute</h3>	</div>
		</div>
	</div>
	<h2>Details will coming soon!!!</h2> 	
	
	<!-- Countdown Start-->
	<!-- launch countdown start -->
	

           <div class="container">
            <div id="DateCountdown" data-date="2016-02-20 00:00:00" style="width: 500px; height: 125px; padding: 0px; box-sizing: border-box; margin-left:320px" align="center"></div>
            <div style="padding: 10px;"> 
                 </div>
            </div>
			
            
        <script>
            $("#DateCountdown").TimeCircles();
            $("#CountDownTimer").TimeCircles({ time: { Days: { show: false }, Hours: { show: false } }});
            $("#PageOpenTimer").TimeCircles();
            
            var updateTime = function(){
                var date = $("#date").val();
                var time = $("#time").val();
                var datetime = date + ' ' + time + ':00';
                $("#DateCountdown").data('date', datetime).TimeCircles().start();
            }
            $("#date").change(updateTime).keyup(updateTime);
            $("#time").change(updateTime).keyup(updateTime);
            
            // Start and stop are methods applied on the public TimeCircles instance
            $(".startTimer").click(function() {
                $("#CountDownTimer").TimeCircles().start();
            });
            $(".stopTimer").click(function() {
                $("#CountDownTimer").TimeCircles().stop();
            });

            // Fade in and fade out are examples of how chaining can be done with TimeCircles
            $(".fadeIn").click(function() {
                $("#PageOpenTimer").fadeIn();
            });
            $(".fadeOut").click(function() {
                $("#PageOpenTimer").fadeOut();
            });

        </script>       
</section>			
			<!-- Countdown End -->
	
	
	

<!--
<section class="subscribe spacing">

<div class="container">
<div id="subscribe">
	<h3>Subscribe To Get Notified</h3>
	<form action="" method="post" onSubmit="">
		<p><input name="" value="Enter your e-mail" type="text" id=""/>
		<input type="button" value="Submit"/></p>
	</form>
	<div id="socialIcons">
		<ul> 
			<li><a href="" title="Twitter" class="twitterIcon"></a></li>
			<li><a href="" title="facebook" class="facebookIcon"></a></li>
			<li><a href="" title="linkedIn" class="linkedInIcon"></a></li>
			<li><a href="" title="Pintrest" class="pintrestIcon"></a></li>
		</ul>
	</div>
	</div>
</div>
</section>
-->
<!--
<section class="features spacing">
  <div class="container">
    <h2 class="text-center">Features</h2>
    <div class="row">
      <div class="col-md-6">
        <div class="featuresPro">
          <div class="col-md-3 col-sm-3 col-xs-3 text-center"><img src="images/icon-1.png" data-at2x="img/icon-1@2x.png" alt="Features"></div>
          <div class="col-md-9 col-sm-9 col-xs-9"> 
            <!--features 1-->
<!--            <h4>Lorem Lpsum</h4>
            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sit, beatae, esse, aspernatur, alias odio numquam incidunt perspiciatis aliquid voluptate sapiente.</p>
            <!--features 1 end--> <!--
          </div>
        </div>
        <div class="featuresPro">
          <div class="col-md-3 col-sm-3 col-xs-3 text-center"><img src="images/icon-2.png" data-at2x="img/icon-2@2x.png" alt="Features"></div>
          <div class="col-md-9 col-sm-9 col-xs-9"> 
            <!--features 2-->
<!--            <h4>Lorem Lpsum</h4>
            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sit, beatae, esse, aspernatur, alias odio numquam incidunt perspiciatis aliquid voluptate sapiente.</p>
            <!--features 2 end--> 
 <!--         </div>
        </div>
      </div>
      <div class="col-md-6">
        <div class="featuresPro">
          <div class="col-md-3 col-sm-3 col-xs-3 text-center"><img src="images/icon-3.png" data-at2x="img/icon-3@2x.png" alt="Features"></div>
          <div class="col-md-9 col-sm-9 col-xs-9"> 
            <!--features 3-->
<!--            <h4>Lorem Lpsum</h4>
            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sit, beatae, esse, aspernatur, alias odio numquam incidunt perspiciatis aliquid voluptate sapiente.</p>
            <!--features 3 end--> 
<!--          </div>
        </div>
        <div class="featuresPro">
          <div class="col-md-3 col-sm-3 col-xs-3 text-center"><img src="images/icon-4.png" data-at2x="img/icon-4@2x.png" alt="Features"></div>
          <div class="col-md-9 col-sm-9 col-xs-9"> 
            <!--features 4-->
<!--            <h4>Lorem Lpsum</h4>
            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sit, beatae, esse, aspernatur, alias odio numquam incidunt perspiciatis aliquid voluptate sapiente.</p>
            <!--features 4 end--> 
 <!--         </div>
        </div>
      </div>
    </div>
  </div>
</section>


<!--Scripts-->

<script type="text/javascript" src="js/comming/jquery-1.9.1.min.js"></script> 
<script type="text/javascript" src="js/comming/global.js"></script>

<!--countdown -->
<!--countdown new-->
		
		<script type="text/javascript" src="js/jquery.knob.js"></script>
		<script type="text/javascript" src="js/countdown.js"></script>
		<script type="text/javascript">
        //<![CDATA[
            $(document).ready(function() {
                "use strict";
                $("#countdown").countdown({
                    date: "20 February 2016 10:00:00", // countdown target date settings
                    format: "on"
                }, function() {
                    // callback function
                });
            });
        //]]>
        </script>
		<script type="text/javascript" src="js/knob.js"></script>

</body>
</html>
