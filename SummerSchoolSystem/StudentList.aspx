<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="StudentList.aspx.cs" Inherits="SummerSchoolSystem.StudentList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered table-hover">
        <tr>
            <th>Student ID</th>
            <th>Student Name</th>
            <th>Student Surname</th>
            <th>Student Number</th>
            <th>Student Password</th>
            <th>Student Mail</th>
            <th>Student Balance</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                <tr>
                    <td>#Eval("StdId")</td>
                    <td>#Eval("StdName")</td>
                    <td>#Eval("StdSurname")</td>
                    <td>#Eval("StdNumber")</td>
                    <td>#Eval("StdPassword")</td>
                    <td>#Eval("StdMail")</td>
                    <td>#Eval("StdBalance")</td>
                    <td>
                        <asp:HyperLink NavigateUrl='<%"~/DeleteStudent.aspx?StdID=4"+ Eval("StudentId")%>' ID="HyperLink1" CssClass="btn btn-danger" runat="server">Delete</asp:HyperLink>
                        <asp:HyperLink ID="HyperLink2" CssClass="btn btn-success" runat="server">Update</asp:HyperLink>
                    </td>
                </tr>
            </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
