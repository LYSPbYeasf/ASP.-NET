<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudentList.aspx.cs" Inherits="StudentList" MasterPageFile="~/Site.master" %>

<asp:Content ID="MainContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

         <div> <h1>Список студентов</h1>
             <asp:GridView ID="GridViewList" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" BorderStyle="Ridge" CaptionAlign="Top" Height="220px" Width="532px">
             <Columns>
                 <asp:BoundField DataField="Фамилия студента" HeaderText="Фамилия студента" SortExpression="Фамилия студента" />
                 <asp:BoundField DataField="Имя" HeaderText="Имя" SortExpression="Имя" />
                 <asp:BoundField DataField="Группa" HeaderText="Группa" SortExpression="Группa" />
                 <asp:BoundField DataField="Общий балл" HeaderText="Общий балл" SortExpression="Общий балл" />
             </Columns>
             </asp:GridView>
             <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StudentBDConnectionString2 %>" 
                 SelectCommand="apf_ListStudent" SelectCommandType="StoredProcedure"></asp:SqlDataSource>                               
         </div>
</asp:Content>