<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RequirementUI.aspx.cs" Inherits="TService.WebForm.RequirementUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../Scripts/easyUI/themes/default/easyui.css" rel="stylesheet" />
    <script src="../Scripts/easyUI/jquery.min.js"></script>
    <script src="../Scripts/easyUI/jquery.easyui.min.js"></script>
    <title></title>
    <script>
        $(function () {
            tableInit();


        })



        function tableInit() {
            $.get("../Handler/data.json", {}, function (data) {
                $("#table").datagrid({
                    //"url": "../Handler/data.json",
                    "toolbar": "#toolBar",
                    "striped": true,
                    "method": "get",
                    "idField": "GUID",
                    "loadMsg": "数据加载中。。。",
                    "rownumbers": true,
                    "checkOnSelect": true,
                    "data":data.rows,
                    "selectOnCheck": true,
                    "pagePosition": "bottom",
                    "pageNumber": 1,
                    "pageSize": 20,
                    "fitColumns": true,
                    "columns": [[
                        { "field": "GUID", "title": "GUID", "checkbox": true, "align": "center", "sortable": true, "resizable": true },
                        { "field": "Title", "title": "提出者", "align": "center", "sortable": true, "resizable": true },
                        { "field": "UserName", "title": "标题", "align": "center", "sortable": true, "resizable": true },
                        { "field": "CreateDate", "title": "提出时间", "align": "center", "sortable": true, "resizable": true },
                        { "field": "Status", "title": "状态", "align": "center", "sortable": true, "resizable": true },
                        { "field": "ExpectFinishDate", "title": "期望完成时间", "align": "center", "sortable": true, "resizable": true },
                        { "field": "ManHour", "title": "工时", "align": "center", "sortable": true, "resizable": true }
                    ]]
                });

            }, "json")
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table id="table"></table>
        </div>
        <div id="toolBar">
            <div style="float: left">
                提出者:
                <input class="easyui-textbox" />
                标题:
                <input class="easyui-textbox" />
                <a id="btnSearch" href="#" class="easyui-linkbutton">查 询</a>
            </div>
            <div style="float: right">
                <a id="btnAdd" href="#" class="easyui-linkbutton">新 增</a>
                <a id="btnUpdate" href="#" class="easyui-linkbutton">修 改</a>
                <a id="btnDelete" href="#" class="easyui-linkbutton">删 除</a>
            </div>
        </div>
    </form>
</body>
</html>
