<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DienDanDemo.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Đăng nhập</title>
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
            <h1 class="ui dividing header">Đăng nhập
                <a class="ui top right attached label label">Một sản phẩm của Phạm Lan Hương 💕</a>
            </h1>
            <form method="POST" action="XuLyLogin.aspx" style="clear: both">
                <div class="ui input">
                    <input type="text" name="username" placeholder="Tài khoản" />
                    <br />
                    <input type="password" name="password" placeholder="Mật khẩu" />
                    <br />
                    <button class="ui primary button">Đăng nhập</button>
                </div>
            </form>
        </div>
    </div>
</body>
</html>
