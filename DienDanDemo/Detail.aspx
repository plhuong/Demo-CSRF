<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detail.aspx.cs" Inherits="DienDanDemo.Detail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Chi tiết</title>
    <link rel="stylesheet" href="semantic.min.css" />
    <link rel="stylesheet" href="style.css" />
</head>
<body>
    <div>
        <div class="ui text container">
            <h1 class="ui dividing header">Chi tiết
                <a class="ui top right attached label label">Một sản phẩm của Phạm Lan Hương 💕</a>
            </h1>
            <a style="float: right; margin-bottom: 1rem; clear: both" class="ui teal tag label" id="hello_user" runat="server">
            </a>
            <a href="Blog.aspx" style="float: right; margin-bottom: 1rem; clear: both" class="ui teal tag label">Blog</a>
            <a href="ChangePassword.aspx" style="float: right; margin-bottom: 1rem; clear: both" class="ui teal tag label">Đổi mật khẩu</a>
            <a href="XuLyDangXuat.aspx" style="float: right; margin-bottom: 1rem; clear: both" class="ui teal tag label">Đăng xuất</a>
            <div class="ui relaxed divided list">
                <p id="content" runat="server"></p>
            </div>
        </div>
    </div>
</body>
</html>
