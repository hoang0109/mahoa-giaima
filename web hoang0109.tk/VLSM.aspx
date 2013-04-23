<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VLSM.aspx.cs" Inherits="VLSM" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
<div align="center">
  <h1>Chia dia chi mang</h1>

  <form action="" method="post" name="netform" id="netform" onSubmit="return addNet();">
    <p><font color="#0000FF" size="2" face="Verdana, Arial, Helvetica, sans-serif"><strong><font color="#FF0000">Step 1: g(example: 205.68.24.0/20)</strong>
        
		<!--address block/MASK TEXT BOX-->
		<input name="cidr" type="text" id="cidr3" size="19">
    
	</font> </p>
    <p><font size="2" face="Verdana, Arial, Helvetica, sans-serif"><strong><font color="#FF0000">Step 2:</font><font color="#0000FF"> Thêm mạng :</font></strong>(example: You need 1 network with 50 addresses, 1 network with 217 addresses and 1 point-to-point<br>
    link. Simply type 50 [Enter] 217 [Enter] 2 [Enter])</font></p>
    <p>
      
	  <!--ENTER NETWORK TEXT BOX-->
	  <input name="hostnum" type="text" id="hostnum" size="3">
       
	   <!--"ADD" BUTTON WHICH CALLS THE addNet() FUNCTION WHEN CLICKED USING THE onSubmit ACTION OF THE FORM-->
	   &nbsp;<input name="addbutton" type="submit" id="addbutton" value="Add">

</p>
    <p>
      
	  <!--INVISIBLE, READ-ONLY TEXT BOX WHERE THE CURRENT ENTERED NETWORKS ARE STORED-->
	  <input type="text" name="networks" size="55" id="networks" style="font-weight:bold;color:#0099FF;font-family:Verdana, Arial, Helvetica, sans-serif;background-color:transparent;border:0" readonly>
     
    </p>
    <p>
      
	  <!--"CLEAR NETWORKS" BUTTON. CALLS THE clearNetworks() FUNCTION WHEN CLICKED-->
	  <input name="sortnum" type="button" id="sortnum" value="Clear Networks" onClick="clearNetworks();">

</p>
    <p>
      
	  <!--"CALCULATE!" BUTTON. CALLS THE sendInfo() FUNCTION WHEN CLICKED-->
	  <input type="button" name="Button" value="Calculate!" onClick="sendInfo();">
    
	</p>
  </form>
  <script language="javascript1.2">
  //this section adds the network address/mask into the text box if the "New Calculation with same address/mask" link is clicked on the calculate.aspx page.
  if(location.search!=""){
       var addnetwork=location.search;
	   addnetwork=addnetwork.substring(1,addnetwork.length);
	   addnetworkArray=addnetwork.split("=");
	   if(addnetworkArray[0]=="net"){
	        addnetwork=addnetworkArray[1];
			document.netform.cidr.value=addnetwork;
			document.netform.hostnum.focus();
	   }
  }
  </script>
    </div>

    </form>
</body>
</html>
