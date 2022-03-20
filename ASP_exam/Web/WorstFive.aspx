<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WorstFive.aspx.cs" Inherits="WorstFive" MasterPageFile="~/Site.master" %>

<asp:Content ID="MainContent" ContentPlaceHolderID="ContentPlaceHolder1"
runat="server">
    <div> <h1>5 худших студентов</h1> <p>

        <asp:GridView ID="Worst5GridView" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" BorderStyle="Ridge" CaptionAlign="Top" Height="220px" Width="532px">
    <Columns>
        <asp:BoundField DataField="Общий балл" HeaderText="Общий балл" SortExpression="Общий балл" />
        <asp:BoundField DataField="Имя" HeaderText="Имя" SortExpression="Имя" />
        <asp:BoundField DataField="Фамилия" HeaderText="Фамилия" SortExpression="Фамилия" />
    </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StudentBDConnectionString2 %>" 
        SelectCommand="apf_WorstStudent" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
         </div>
    </asp:Content>