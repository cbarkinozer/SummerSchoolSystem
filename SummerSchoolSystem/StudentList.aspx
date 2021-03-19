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
    </tr>
        <tbody>
            <tr>
                <td>1</td>
                <td>Barkın</td>
                <td>Özer</td>
                <td>1234</td>
                <td>12345</td>
                <td>test@email.com</td>
            </tr>
        </tbody>
    </table>
</asp:Content>
