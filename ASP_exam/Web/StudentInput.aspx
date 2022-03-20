<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudentInput.aspx.cs" Inherits="StudentInput" MasterPageFile="~/Site.master" UnobtrusiveValidationMode="None" %>

<asp:Content ID="MainContent" ContentPlaceHolderID="ContentPlaceHolder1"
runat="server">
        <div>
            <h1>Форма учета успеваемости студента</h1>
                 <div> 
                     <blockquote>
                        <label>Имя студента:</label><br />                        
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="StFirstName" ErrorMessage="Заполните поле имени" ForeColor="Red">Необходимо ввести имя</asp:RequiredFieldValidator>
                     </blockquote>
                     <asp:TextBox ID="StFirstName" runat="server" Width="200px"></asp:TextBox>                       
                 </div>
                 <div>      
                     <blockquote>
                         <label>Фамилия студента</label><br />                                              
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="StLastName" ErrorMessage="Заполните поле Фамилия студента" ForeColor="Red">Необходимо ввести фамилию</asp:RequiredFieldValidator>
                     </blockquote>
                     <asp:TextBox ID="StLastName" runat="server" Width="200px"></asp:TextBox>                    
                 </div> 
                 <div>
                     <blockquote>
                         <label>Номер группы:</label><br />                          
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="groupNumber" ErrorMessage="Введите номер группы" ForeColor="Red">Необходимо ввести номер группы</asp:RequiredFieldValidator>
                     </blockquote>
                     <asp:TextBox ID="groupNumber" runat="server" Width="200px"></asp:TextBox>                     
                     </div>
          </div><br />                   
            <div>
                <h2>Дисциплины:</h2></div>
                <div>
                    <table style="width:100%;">
                         <tr>
                             <td>
                   <div style="text-align: right"> 
                       <blockquote style="text-align: center">
                           <span style="text-decoration: underline"><em>Windows Forms Course:</em></span></blockquote>
                                 </div>
                             </td>
                             <td style="width: 193px"><em><asp:TextBox ID="TextBoxWF" runat="server" Width="70px" style="text-decoration: underline"></asp:TextBox> </em> </td>
                         </tr>
                         <tr>
                             <td>
                   <div style="text-align: right"> 
                       <blockquote style="text-align: center">
                           <span style="text-decoration: underline"><em>C# Course:</em></span></blockquote>
                                 </div>
                             </td>
                             <td style="width: 193px"><em><asp:TextBox ID="TextBoxCsharp" runat="server" Width="70px" style="text-decoration: underline"></asp:TextBox> </em> </td>
                         </tr>
                         <tr>
                             <td>
                   <div style="text-align: right"> 
                       <blockquote style="text-align: center">
                           <span style="text-decoration: underline"><em>Transact SQL Course:</em></span></blockquote>
                                 </div>
                             </td>
                             <td style="width: 193px"><em><asp:TextBox ID="TextBoxTSQL" runat="server" Width="70px" style="text-decoration: underline"></asp:TextBox> </em> </td>
                         </tr>
                         <tr>
                             <td>
                   <div style="text-align: right"> 
                       <blockquote style="text-align: center">
                           <span style="text-decoration: underline"><em>ASP.NET Course:</em></span></blockquote>
                                 </div>
                             </td>
                             <td style="width: 193px"><em><asp:TextBox ID="TextBoxASP" runat="server" Width="70px" style="text-decoration: underline"></asp:TextBox> </em> </td>
                         </tr>
                         <tr>
                             <td>
                   <div style="text-align: right"> 
                       <blockquote style="text-align: center">
                           <span style="text-decoration: underline"><em>ADO.NET Course:</em></span></blockquote>
                                 </div>
                             </td>
                             <td style="width: 193px"><em><asp:TextBox ID="TextBoxADO" runat="server" Width="70px" style="text-decoration: underline"></asp:TextBox> </em> </td>
                         </tr>
                     </table>
                     <button type="submit">Отправить</button>
                </div><br /> 
    <div><asp:Label ID="ExcpLabel" runat="server"></asp:Label></div>
</asp:Content>