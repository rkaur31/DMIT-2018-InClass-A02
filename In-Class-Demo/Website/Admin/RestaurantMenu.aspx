﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="RestaurantMenu.aspx.cs" Inherits="Admin_RestaurantMenu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="row col-md-12">
        <h1>Our Menu Items</h1>
        <asp:Repeater ID="MenuItemRepeater" runat="server"
            DataSourceID="MenuItemDataSource">
            <ItemTemplate>
               <div>
                   <%# ((decimal)Eval("CurrentPrice")).ToString("C") %>
                   &mdash;
                   <%# Eval("Description") %>
                   &mdash;
                   <%# Eval("Calories") %>
                   &mdash;
                  <%# Eval("Description") %>
            </ItemTemplate>
            <SeparatorTemplate>
                <hr />
            </SeparatorTemplate>
        </asp:Repeater>
        <asp:ObjectDataSource ID="MenuItemDataSource" runat="server"
            OldValuesParameterFormatString="original_{0}" SelectMethod="ListMenuItems"
            TypeName="eRestaurant.Framework.BLL.MenuController">

        </asp:ObjectDataSource>
    </div>
</asp:Content>

