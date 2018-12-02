<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="findmate.aspx.cs" Inherits="ChargeMate.findmate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="refresh" content="10" >
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content mt-3">
        <div class="card">
            <div class="card-header">
                Battery Status
            </div>
            <div class="card-body">
                <div class="progress mb-2">
                    <div id="prg" runat="server" class="progress-bar bg-danger progress-bar-striped progress-bar-animated" role="progressbar"
                        style="width: 20%" aria-valuenow="20" aria-valuemin="0" aria-valuemax="100">
                        20%
                    </div>
                </div>

            </div>
        </div>
        <div class="card">
            <div class="card-header">
                Find your Mate
            </div>
            <div class="card-body">
                <asp:Button ID="btnFind" CssClass="btn btn-primary btn-lg btn-block" OnClick="btnFind_Click"
                    runat="server" Text="Find the nearest car" />
            </div>
        </div>

        <div class="card" runat="server" id="cardResult" style="display: none;">
            <div class="card-header">
                Your mate is ready. Estimated point to start pairing is shown below. Drive safe.
            </div>
            <div class="card-body">
                <asp:Image ImageUrl="~/images/match.PNG" ID="imgMatch" runat="server" />
                <asp:Label ID="lblPlate" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>

