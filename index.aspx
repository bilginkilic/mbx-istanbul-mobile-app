<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ChargeMate.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content mt-3">
        <div class="col-xl-3 col-lg-6">
            <section class="card">
                <div class="twt-feed blue-bg">
                    <div class="corner-ribon black-ribon">
                        <i class="fa fa-car"></i>
                    </div>
                    <div class="fa fa-twitter wtt-mark"></div>

                    <div class="media">
                        <a href="#">
                            <img class="align-self-center rounded-circle mr-3" style="width: 85px; height: 70px;" alt="" src="images/admin.png">
                        </a>
                        <div class="media-body">
                            <h2 class="text-white display-6">Mercedes A180</h2>
                            <p class="text-light">34 AB 123</p>
                        </div>
                    </div>
                </div>
                <div class="weather-category twt-category">
                    <ul>
                        <li class="active">
                            <h5>280</h5>
                            Points
                            </li>
                        <li>
                            <h5>10</h5>
                            Mate
                            </li>
                        <li>
                            <h5>45 KW</h5>
                            Saved Energy
                            </li>
                    </ul>
                </div>
                <footer class="twt-footer">
                    <a href="#"><i class="fa fa-camera"></i></a>
                    <a href="#"><i class="fa fa-map-marker"></i></a>
                    Istanbul, TURKEY
                       
                    <span class="pull-right">123203
                        </span>
                </footer>
            </section>
        </div>
    </div>
</asp:Content>
