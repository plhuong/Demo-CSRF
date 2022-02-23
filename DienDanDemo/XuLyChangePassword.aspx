<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XuLyChangePassword.aspx.cs" Inherits="DienDanDemo.XuLyChangePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Đổi mật khẩu</title>
    <link rel="stylesheet" href="semantic.min.css" />
    <link rel="stylesheet" href="style.css" />
    <style type="text/css">
        .ui.input{
            display: block;
        }

        .ui.input input{
            margin: 5px 0;
        }
    </style>
</head>
<body>
    <div>
        <div class="ui text container">
            <h1 class="ui dividing header"><label id="result_text" runat="server">Đổi mật khẩu</label>
                <a class="ui top right attached label label">Một sản phẩm của Phạm Lan Hương 💕</a>
            </h1>
            <a style="float: right; margin-bottom: 1rem; clear: both" class="ui teal tag label" id="hello_user" runat="server">
            </a>
            <a href="Blog.aspx" style="float: right; margin-bottom: 1rem; clear: both" class="ui teal tag label">Blog</a>
            <a href="ChangePassword.aspx" style="float: right; margin-bottom: 1rem; clear: both" class="ui teal tag label">Đổi mật khẩu</a>
            <a href="XuLyDangXuat.aspx" style="float: right; margin-bottom: 1rem; clear: both" class="ui teal tag label">Đăng xuất</a>
        </div>
    </div>
</body>
</html>
