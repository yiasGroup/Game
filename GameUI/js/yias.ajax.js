
function getMyHeaders() {
    return $.cookie('myHeaders');
}
function setMyHeaders(vals) {
    return $.cookie('myHeaders', vals);
}
if (!getMyHeaders()) {
    setMyHeaders('NotLogin');
}
if (yias) {
    jQuery.support.cors = true;
    //样式

    var _ajax = $.ajax;
    $.ajax = function (options) {
        //2.每次调用发送ajax请求的时候定义默认的error处理方法
        var fn = {
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert(XMLHttpRequest.responseText);
            },
            success: function (data, textStatus) { },
            beforeSend: function (XHR) { },
            complete: function (XHR, TS) { }
        }
        //3.扩展原生的$.ajax方法，返回最新的参数
        var _options = $.extend({}, {
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                fn.error(XMLHttpRequest, textStatus, errorThrown);
            },
            success: function (data, textStatus) {
                fn.success(data, textStatus);
            },
            beforeSend: function (XHR) {
                //XHR.setRequestHeader('Authorization', 'BasicAuth ' + getCookie());
                //XHR.setRequestHeader("Access-Control-Allow-Origin", "*, *");
                //  alert(getmodule())
                fn.beforeSend(XHR);
            },
            complete: function (XHR, TS) {
                fn.complete(XHR, TS);
            }
        }, options);
        //4.将最新的参数传回ajax对象
        _ajax(_options);
    };

    yias.ajax = {
        _ajaxurl: "http://localhost:58551/service/send",
        _root: { "type": "json" },
        load: function () {
            this._root = { "type": "json" };
        },
        add: function (Key, Value) {
            this._root[Key] = Value;
        },
        _getXML: function () {
            var retXml = toJSON(this._root);
            while (retXml.indexOf("'") != -1) {
                retXml = retXml.replace("'", "[+|+]");
            }
            return (retXml + "");
        },
        get: function (Key) {
            return this._root[Key];
        },
        send: function (BusinessName, ClassName, Method, DBResponse) {
            if (!BusinessName || BusinessName == "") {
                alert("请添加类库名称");
                return;
            }
            if (!ClassName || ClassName == "") {
                alert("请添加类名称");
                return;
            }
            if (!Method || Method == "") {
                alert("请添加方法名称");
                return;
            }
            this.add("typeName", BusinessName + "." + ClassName);
            this.add("Method", Method);
            this.add("types", "Method");
            this.add("BusinessName", BusinessName);
            $.ajax({// ajax Begin
                type: 'post',
                dataType: 'json',
                url: yias.ajax._ajaxurl,
                data: yias.ajax._getXML(),
                headers: { "Authorization": "GameUI " + getMyHeaders() },
                contentType: "application/json; charset=utf-8",
                cache: false,
                async: false,
                success: function (rea) {
                    var func = eval(DBResponse);
                    new func(rea);

                }, //success end
                error: function (result) {
                    var obj = null;
                    try {
                        if (result.response) {
                            obj = eval('(' + result.response + ')')
                        } else {
                            obj = eval('(' + result.responseText + ')')
                        }
                        alert("错误：" + obj.Message);
                    } catch (e) {
                        alert("返回值错误：" + e.message);
                    }
                }
            });
            this.load();
        }
    }
}
else
    alert("尚未加载yias");

function success_jsonpCallback() {
    alert("break");
}
