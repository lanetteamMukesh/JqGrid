<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UploadMultipleFiles.aspx.cs" Inherits="MultipleUpload.UploadMultipleFiles" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Multiple File Uploaders</title>
    <!--<script src="scripts/jquery.js"></script>-->
    <script src="scripts/jquery-1.7.2.min.js"></script>
    <script>

        $(function () {


            var scndDiv = $('#FileUpload');
            var i = $('#FileUpload p').size + 1;

            $('#addFiles').live('click', function () {
                //   alert("Hello");

                $('<p><input type="file" id="flUploaders' + i + '" name="flUploaders' + i + '"><a href="#" id="rmUploaders">remove</a></p>').appendTo(scndDiv);
                i++;
                return false;
            });

            $('#rmUploaders').live('click',function(){
                alert('Remove called..');

              //  debugger
                alert('Remove called twice..');
               /* if (i > 2)
                {*/
                    $(this).parents('p').remove();
                    i--;
              //  }

                return false;
        
        });
        
            
           


        });

      

        //$(document).ready(function () {

        //    $("#btnUpload").click(function () {

        //        alert("Hello");
        //    })
        //})

    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div style="padding:10px;border:1px solid black">
        <div id="FileUpload">
      <p>  <asp:FileUpload ID="flUpload" runat="server" /></p>
        </div>

        <a href="#" id="addFiles" style  ="color:blue;text-decoration:none;font:20px bold vardana">Add another files to upload</a><br /><br />

        <asp:Button ID="btnUpload" runat="server" Text="Button" OnClick="btnUpload_Click" /><br /><br /><br />
    </div><br /><br />
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
            <FooterStyle BackColor="White" ForeColor="#333333" />
            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#487575" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#275353" />
        </asp:GridView>

   
    </form>
</body>
</html>
