<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudentSave.aspx.cs" Inherits="StudentSave" MasterPageFile="~/Site.master" %>

<asp:Content ID="MainContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         <div> <h1>Форма успешно зарегистрированна.</h1> </div>
    <div>
        Информация о студенте успешно внесена в систему.
    </div>
    <div> 
            <li><a href="StudentInput.aspx">Заполнить еще одну форму</a></li> 
            <li><a href="BestFive.aspx">"5 лучших студентов"</a></li> 
            <li><a href="StudentList.aspx">Список студентов</a></li> 
            <li><a href="WorstFive.aspx">5 худших студентов</a></li> 
    </div>
</asp:Content>
