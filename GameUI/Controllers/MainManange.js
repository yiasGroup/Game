var tTable = null;
var mbbh = null;
function CreateTable() {
    tTable = new aceTable("table");
    tTable.cols.push(new Cols(null, '模板名称', '', 'modelName', '', null));
    tTable.name = "tTable";

    tTable.itemupdate = function (btn) {
        var item = tTable.GetItemByBtn(btn);
        GetModels(item.ID, item.modelName);
    }
    tTable.itemdelete = function (btn) {
        var item = tTable.GetItemByBtn(btn);
        if (confirm("是否确定删除？")) {
            yias.ajax.add("info", { ID: item.ID });
            yias.ajax.send("GameBLL", "gameModelsBLL", "Delete", function (ret) {
                BindTable();
            });
        }
    }
    tTable.initCreate();
    BindTable();
}

function BindTable() {
    yias.ajax.send("GameBLL", "gameModelsBLL", "GetListAll", function (ret) {
        tTable.items.length = 0;
        for (var i = 0; i < ret.length; i++) {
            tTable.items.push({ 'modelName': ret[i]._modelName, 'ID': ret[i]._ID });
        }
        tTable.DataBind();
    });
}

function GetModels(id, modelname) {
    mbbh = id; ClearFrom();
    getd("txtgameName").value = modelname;
    yias.ajax.add("mid", id);
    yias.ajax.send("GameBLL", "gameConfigBLL", "GetListByModelID", function (ret) {
        getd("txtyxts").value = GetValueByName("游戏天数", ret);
        getd("txtmtms").value = GetValueByName("每天秒数", ret);
        getd("txtcgdj").value = GetValueByName("采购单价", ret);
        getd("txtmlr").value = GetValueByName("毛利润", ret);
        getd("txtjhfk").value = GetValueByName("交货罚款", ret);
        getd("txtzcxl").value = GetValueByName("正常销量", ret);
        getd("txtysjs").value = GetValueByName("运输基数", ret);
        getd("txtdhcb").value = GetValueByName("订货成本", ret);
        $("#divnr").show();
    });
}
function InsertMb() {
    $("#divmb").show();
}
function CloseMb() {
    $("#divmb").hide();
}
function Closenr() {
    $("#divnr").hide();
    mbbh = null;
}
function Save() {
    if (mbbh == null) {
        if (getd("txtgameModels").value != "") {
            yias.ajax.add("info", { modelName: getd("txtgameModels").value });
            yias.ajax.send("GameBLL", "gameModelsBLL", "Insert", function (ret) {
                BindTable();
                CloseMb();
            });
        } else
            alert("请录入模板名称！");
    } else {
        if (!isFloat(getd("txtyxts").value)) {
            alert("请正确输入游戏天数！");
            return;
        }
        if (!isFloat(getd("txtmtms").value)) {
            alert("请正确输入每天秒数！");
            return;
        }
        if (!isFloat(getd("txtcgdj").value)) {
            alert("请正确输入采购单价！");
            return;
        }
        if (!isFloat(getd("txtmlr").value)) {
            alert("请正确输入毛利润！");
            return;
        }
        if (!isFloat(getd("txtjhfk").value)) {
            alert("请正确输入交货罚款！");
            return;
        }
        if (!isFloat(getd("txtzcxl").value)) {
            alert("请正确输入正常销量！");
            return;
        }
        if (!isFloat(getd("txtysjs").value)) {
            alert("请正确输入运输基数！");
            return;
        }
        if (!isFloat(getd("txtdhcb").value)) {
            alert("请正确输入订货成本！");
            return;
        }
        yias.ajax.add("mid", mbbh);
        yias.ajax.add("list", [
            { congfigname: "游戏天数", configtype: "system", configvalue: getd("txtyxts").value, gameModelID: mbbh },
            { congfigname: "每天秒数", configtype: "system", configvalue: getd("txtmtms").value, gameModelID: mbbh },
            { congfigname: "采购单价", configtype: "system", configvalue: getd("txtcgdj").value, gameModelID: mbbh },
            { congfigname: "毛利润", configtype: "system", configvalue: getd("txtmlr").value, gameModelID: mbbh },
            { congfigname: "交货罚款", configtype: "system", configvalue: getd("txtjhfk").value, gameModelID: mbbh },
            { congfigname: "正常销量", configtype: "system", configvalue: getd("txtzcxl").value, gameModelID: mbbh },
            { congfigname: "运输基数", configtype: "system", configvalue: getd("txtysjs").value, gameModelID: mbbh },
            { congfigname: "订货成本", configtype: "system", configvalue: getd("txtdhcb").value, gameModelID: mbbh }
        ]);
        yias.ajax.send("GameBLL", "gameConfigBLL", "AddList", function (ret) {
            mbbh = null;
            ClearFrom();
            Closenr();
        });
    }
}
function GetValueByName(name, list) {
    for (var i = 0; i < list.length; i++) {
        if (name == list[i]._congfigname) {
            return list[i]._configvalue;
        }
    }
    return "";
}
function ClearFrom() {
    getd("txtyxts").value = '';
    getd("txtmtms").value = '';
    getd("txtcgdj").value = '';
    getd("txtmlr").value = '';
    getd("txtjhfk").value = '';
    getd("txtzcxl").value = '';
    getd("txtysjs").value = '';
    getd("txtdhcb").value = '';
}
function isFloat(num) {
    if (num) {
        try {
            parseFloat(num);
            return true;
        } catch (e) { }
    }
    return false;
}