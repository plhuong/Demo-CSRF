<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Blog.aspx.cs" Inherits="DienDanDemo.Blog" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Mạng xã hội</title>
    <link rel="stylesheet" href="semantic.min.css" />
    <link rel="stylesheet" href="style.css" />
</head>
<body>
    <div>
        <div class="ui text container">
            <h1 class="ui dividing header">Mạng Xã Hội
                <a class="ui top right attached label label">Một sản phẩm của Phạm Lan Hương 💕</a>
            </h1>
            <a style="float: right; margin-bottom: 1rem; clear: both" class="ui teal tag label" id="hello_user" runat="server">
            </a>
            <a href="Blog.aspx" style="float: right; margin-bottom: 1rem; clear: both" class="ui teal tag label">Blog</a>
            <a href="ChangePassword.aspx" style="float: right; margin-bottom: 1rem; clear: both" class="ui teal tag label">Đổi mật khẩu</a>
            <a href="XuLyDangXuat.aspx" style="float: right; margin-bottom: 1rem; clear: both" class="ui teal tag label">Đăng xuất</a>
            <form method="GET" style="clear: both" action="XuLyDangBlog.aspx">
                <div class="ui fluid action input">
                    <input type="text" name="content" placeholder="Bạn đang nghĩ gì?" />
                    <button class="ui primary button">Post</button>
                </div>
            </form>
            <div class="ui relaxed divided list" id="list_item" runat="server">
            </div>
        </div>
    </div>
</body>
</html>
